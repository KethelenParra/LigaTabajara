using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LigaTabajara.DAL;
using LigaTabajara.Models;
using LigaTabajara.ViewModels;

namespace LigaTabajara.Controllers
{
    public class PartidasController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();
        private static readonly Random _rng = new Random();

        // GET: Partidas
        public ActionResult Index(
            int? round,
            string searchJogo,
            string estadio
        )
        {
            // 1) coleta todas as rodadas
            var allRounds = db.Partidas
                              .Select(p => p.Round)
                              .Distinct()
                              .OrderBy(r => r)
                              .ToList();

            // 2) carrega partidas com TimeMandante e TimeVisitante
            var partidas = db.Partidas
                              .Include(p => p.TimeMandante)
                              .Include(p => p.TimeVisitante)
                              .OrderBy(p => p.Round)
                              .ThenBy(p => p.DataPartida)
                              .ToList();

            // 3) filtra por rodada
            var schedule = round.HasValue
                ? partidas.Where(p => p.Round == round.Value).ToList()
                : partidas;

            // 4) filtra por “jogo” (mandante OU visitante)
            if (!String.IsNullOrWhiteSpace(searchJogo))
            {
                schedule = schedule
                    .Where(p =>
                        p.TimeMandante.Nome
                         .IndexOf(searchJogo, StringComparison.OrdinalIgnoreCase) >= 0
                     || p.TimeVisitante.Nome
                         .IndexOf(searchJogo, StringComparison.OrdinalIgnoreCase) >= 0
                    )
                    .ToList();
            }

            // 5) filtra por estádio (APENAS do mandante!)
            if (!String.IsNullOrWhiteSpace(estadio))
            {
                schedule = schedule
                    .Where(p =>
                        p.TimeMandante.Estadio.Equals(estadio, StringComparison.OrdinalIgnoreCase)
                    )
                    .ToList();
            }

            // 6) monta lista de opções de estádio para o dropdown
            var estadioOptions = db.Times
                .Select(t => t.Estadio)
                .Distinct()
                .OrderBy(e => e)
                .Select(e => new SelectListItem
                {
                    Text = e,
                    Value = e,
                    Selected = (e.Equals(estadio, StringComparison.OrdinalIgnoreCase))
                });

            // 7) constroi o ViewModel
            var vm = new PartidaIndexView
            {
                Rounds = allRounds,
                Round = round,
                Schedule = schedule,
                SearchJogo = searchJogo,
                SelectedEstadio = estadio,
                EstadioOptions = estadioOptions
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LimparCalendario()
        {
            // Apaga todas as estatísticas (FK)
            db.EstatisticasJogos.RemoveRange(db.EstatisticasJogos);
            // Apaga todas as partidas
            db.Partidas.RemoveRange(db.Partidas);
            db.SaveChanges();

            TempData["Success"] = "Calendário inteiramente removido!";
            return RedirectToAction("Index");
        }

        // GET: Partidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var partida = db.Partidas
                             .Include(p => p.TimeMandante)
                             .Include(p => p.TimeVisitante)
                             .Include(p => p.EstatisticasJogos.Select(e => e.Jogador))
                             .FirstOrDefault(p => p.Id == id);

            if (partida == null) return HttpNotFound();
            return View(partida);
        }

        // GET: Partidas/Create
        public ActionResult Create()
        {
            ViewBag.TimeMandanteId = new SelectList(db.Times, "Id", "Nome");
            ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: Partidas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DataPartida,TimeMandanteId,TimeVisitanteId,GolsMandante,GolsVisitante")] Partida partida)
        {
            // nova validação de "apto"
            if (!IsTeamApto(partida.TimeMandanteId) || !IsTeamApto(partida.TimeVisitanteId))
            {
                ModelState.AddModelError("",
                    "Não é possível cadastrar esta partida: um ou ambos os times não estão aptos para jogar.");
                ViewBag.TimeMandanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeMandanteId);
                ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeVisitanteId);
                return View(partida);
            }

            if (ModelState.IsValid)
            {
                // Validação: os times não podem ser os mesmos
                if (partida.TimeMandanteId == partida.TimeVisitanteId)
                {
                    ModelState.AddModelError("", "O Time Mandante e o Time Visitante não podem ser o mesmo.");
                    ViewBag.TimeMandanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeMandanteId);
                    ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeVisitanteId);
                    return View(partida);
                }

                db.Partidas.Add(partida);
                db.SaveChanges();

                // gera estatísticas automaticamente
                RegistrarEstatisticasAutomaticas(partida);

                return RedirectToAction("Index");
            }

            ViewBag.TimeMandanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeMandanteId);
            ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeVisitanteId);
            return View(partida);
        }

        // Gerar automaticamente as estatísticas de gols de uma partida
        private void RegistrarEstatisticasAutomaticas(Partida partida)
        {
            DistribuirGols(partida.Id, partida.TimeMandanteId, partida.GolsMandante.GetValueOrDefault());
            DistribuirGols(partida.Id, partida.TimeVisitanteId, partida.GolsVisitante.GetValueOrDefault());
            db.SaveChanges();
            db.SaveChanges();
        }

        private void DistribuirGols(int partidaId, int timeId, int totalGols)
        {
            if (totalGols <= 0) return;

            // busca todos os jogadores válidos
            var possiveis = db.Jogadores
                .Where(j => j.TimeId == timeId && j.Posicao != Posicao.Goleiro)
                .ToList();
            if (!possiveis.Any()) return;

            // sorteia um jogador para cada gol
            var goalsByPlayer = new Dictionary<int, int>();
            for (int i = 0; i < totalGols; i++)
            {
                var escolhido = possiveis[_rng.Next(possiveis.Count)];
                if (!goalsByPlayer.ContainsKey(escolhido.ID))
                    goalsByPlayer[escolhido.ID] = 0;
                goalsByPlayer[escolhido.ID]++;
            }

            // insere um registro por jogador com a soma dos gols
            foreach (var kv in goalsByPlayer)
            {
                db.EstatisticasJogos.Add(new EstatisticaJogo
                {
                    PartidaId = partidaId,
                    JogadorId = kv.Key,
                    Gols = kv.Value
                });
            }
        }


        [HttpPost]
        public ActionResult RecalcularEstatisticas()
        {
            // remove tudo
            db.EstatisticasJogos.RemoveRange(db.EstatisticasJogos);
            db.SaveChanges();

            // pega só partidas com resultados
            var partidas = db.Partidas
                             .Where(p => p.GolsMandante.HasValue && p.GolsVisitante.HasValue)
                             .ToList();

            // regenera
            foreach (var p in partidas)
                RegistrarEstatisticasAutomaticas(p);

            TempData["Success"] = "Estatísticas recalculadas para todas as partidas!";
            return RedirectToAction("Index");
        }

        // NOVA AÇÃO: GerarPartidas – calendário com turno e returno
        public ActionResult GerarPartidas()
        {
            if (!IsLeagueApto())
            {
                TempData["Error"] =
                    "Não é possível gerar o calendário: a liga ainda não está apta. "
                  + "Garanta que todos os times tenham ao menos 30 jogadores e 6 cargos distintos na comissão.";
                return RedirectToAction("Index");
            }

            // 0) Limpa as estatísticas (evita FK violation)
            db.EstatisticasJogos.RemoveRange(db.EstatisticasJogos);
            db.SaveChanges();

            // 1) Limpa todas as partidas existentes
            db.Partidas.RemoveRange(db.Partidas);
            db.SaveChanges();

            // 2) Recarrega os times e valida
            var times = db.Times.ToList();
            if (times.Count != 20)
            {
                TempData["Error"] = "É necessário ter exatamente 20 times cadastrados para gerar o calendário.";
                return RedirectToAction("Index");
            }

            var naoAptos = times.Where(t => !IsTeamApto(t.Id))
                       .Select(t => t.Nome)
                       .ToList();
            if (naoAptos.Any())
            {
                TempData["Error"] =
                  "Não é possível gerar o campeonato: os seguintes times não estão aptos:\n"
                  + string.Join(", ", naoAptos);
                return RedirectToAction("Index");
            }

            // ** EMBARALHA os times aleatoriamente **
            times = times.OrderBy(t => _rng.Next()).ToList();

            int n = times.Count;           // 20 times
            int rounds = n - 1;            // 19 rodadas na 1ª perna
            int perRound = n / 2;          // 10 jogos por rodada
            var teamIds = times.Select(t => t.Id).ToList();

            // 2) Calcula a próxima segunda-feira como data base
            DateTime today = DateTime.Today;
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime baseMonday = today.AddDays(daysUntilMonday);

            var partidas = new List<Partida>();

            // 3) Gera 1ª perna
            for (int r = 0; r < rounds; r++)
            {
                // data de início da semana da rodada r
                DateTime weekStart = baseMonday.AddDays(r * 7);

                for (int i = 0; i < perRound; i++)
                {
                    int h = (i % 2 == 0) ? teamIds[i] : teamIds[n - 1 - i];
                    int a = (i % 2 == 0) ? teamIds[n - 1 - i] : teamIds[i];

                    // escolhe dia aleatório dentro da semana [0..6]
                    int offset = _rng.Next(0, 7);
                    partidas.Add(new Partida
                    {
                        Round = r + 1,
                        TimeMandanteId = h,
                        TimeVisitanteId = a,
                        DataPartida = weekStart.AddDays(offset)
                    });
                }

                // rota a lista (algoritmo círculo)
                var last = teamIds.Last();
                teamIds.RemoveAt(n - 1);
                teamIds.Insert(1, last);
            }

            // 4) Gera 2ª perna (returno), invertendo mandante/visitante
            int firstLegCount = partidas.Count;
            for (int i = 0; i < firstLegCount; i++)
            {
                var orig = partidas[i];
                // usa a mesma semana, mas rodada = rounds + (orig.Round)
                partidas.Add(new Partida
                {
                    Round = orig.Round + rounds,
                    TimeMandanteId = orig.TimeVisitanteId,
                    TimeVisitanteId = orig.TimeMandanteId,
                    // mantém o mesmo deslocamento de dia dentro da semana
                    DataPartida = orig.DataPartida
                });
            }

            // 5) Salva tudo
            db.Partidas.AddRange(partidas);
            db.SaveChanges();

            TempData["Success"] = "Calendário gerado com sucesso!";
            return RedirectToAction("Index");
        }

        // GET: Partidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var partida = db.Partidas.Find(id);
            if (partida == null)
                return HttpNotFound();

            // preenche os dropdowns
            ViewBag.TimeMandanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeMandanteId);
            ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome", partida.TimeVisitanteId);

            return View(partida);
        }


        // POST: Partidas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            int id,
            [Bind(Include="Id,DataPartida,TimeMandanteId,TimeVisitanteId,GolsMandante,GolsVisitante")]
            Partida partidaDoForm)
        {
            if (!IsLeagueApto())
            {
                ModelState.AddModelError("",
                  "Não é possível editar partidas: a liga ainda não está apta (alguns times não cumprem os requisitos).");
                return View(partidaDoForm);
            }

            // 1) Reponha sempre os SelectLists no ViewBag
            ViewBag.TimeMandanteId = new SelectList(db.Times, "Id", "Nome", partidaDoForm.TimeMandanteId);
            ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome", partidaDoForm.TimeVisitanteId);

            if (!ModelState.IsValid)
            {
                // aqui o ViewBag já está preenchido, então os <select> não ficarão vazios
                return View(partidaDoForm);
            }

            // 2) Carregue a entidade original
            var partidaOriginal = db.Partidas.Find(id);
            if (partidaOriginal == null)
                return HttpNotFound();

            // --- NOVA VALIDAÇÃO: não deixar editar rodada N se existir partida sem resultado na rodada N‑1 ---
            var rodadaAtual = partidaOriginal.Round;
            if (rodadaAtual > 1)
            {
                var faltaRegistrio = db.Partidas.Any(p =>
                    p.Round == rodadaAtual - 1
                    && (!p.GolsMandante.HasValue || !p.GolsVisitante.HasValue)
                );
                if (faltaRegistrio)
                {
                    ModelState.AddModelError(
                        "",
                        $"Você deve registrar todos os resultados da rodada {rodadaAtual - 1} antes de editar uma partida da rodada {rodadaAtual}."
                    );
                    return View(partidaDoForm);
                }
            }

            // 3) Limpe estatísticas antigas
            var antigas = db.EstatisticasJogos.Where(e => e.PartidaId == id);
            db.EstatisticasJogos.RemoveRange(antigas);
            db.SaveChanges();

            // 4) Aplique as alterações vindas do form
            partidaOriginal.DataPartida = partidaDoForm.DataPartida;
            partidaOriginal.TimeMandanteId = partidaDoForm.TimeMandanteId;
            partidaOriginal.TimeVisitanteId = partidaDoForm.TimeVisitanteId;
            partidaOriginal.GolsMandante = partidaDoForm.GolsMandante;
            partidaOriginal.GolsVisitante = partidaDoForm.GolsVisitante;
            // **não mexemos em partidaOriginal.Round**

            db.SaveChanges();

            // 4) Regera estatísticas com base no novo placar
            RegistrarEstatisticasAutomaticas(partidaOriginal);

            return RedirectToAction("Index");
        }
        private bool IsLeagueApto()
        {
            // busca todos os times do banco primeiro
            var allTimes = db.Times
                             .Select(t => t.Id)
                             .ToList(); // materializa no cliente

            // agora roda o All em memória, chamando seu IsTeamApto normalmente
            return allTimes.All(id => IsTeamApto(id));
        }

        private bool IsTeamApto(int timeId)
        {
            // pelo menos 30 jogadores
            bool hasMinPlayers = db.Jogadores.Count(j => j.TimeId == timeId) >= 30;
            // comissão técnica – exatamente 6 cargos, cada um único
            var cargos = db.ComissoesTecnicas
                           .Where(c => c.TimeId == timeId)
                           .Select(c => c.Cargo)
                           .ToList();
            bool hasMinComissao = cargos.Count == 6 && cargos.Distinct().Count() == 6;
            return hasMinPlayers && hasMinComissao;
        }

        // GET: Partidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // POST: Partidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Partida partida = db.Partidas.Find(id);
            db.Partidas.Remove(partida);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
