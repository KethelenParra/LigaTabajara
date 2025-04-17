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

namespace LigaTabajara.Controllers
{
    public class PartidasController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();
        private static readonly Random _rng = new Random();

        // GET: Partidas
        public ActionResult Index()
        {
            var partidas = db.Partidas
                               .Include(p => p.TimeMandante)
                               .Include(p => p.TimeVisitante)
                               .OrderBy(p => p.Round)
                               .ThenBy(p => p.DataPartida);
            return View(partidas.ToList());
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
            // só faz algo se houve gols marcados
            if (partida.GolsMandante.GetValueOrDefault() > 0)
            {
                var possiveisMandantes = db.Jogadores
                    .Where(j => j.TimeId == partida.TimeMandanteId
                             && j.Posicao != Posicao.Goleiro)
                    .ToList();

                if (possiveisMandantes.Any())
                {
                    // sorteia um jogador aleatoriamente
                    var escolhido = possiveisMandantes[_rng.Next(possiveisMandantes.Count)];
                    db.EstatisticasJogos.Add(new EstatisticaJogo
                    {
                        PartidaId = partida.Id,
                        JogadorId = escolhido.ID,
                        Gols = partida.GolsMandante.Value
                    });
                }
            }

            if (partida.GolsVisitante.GetValueOrDefault() > 0)
            {
                var possiveisVisitantes = db.Jogadores
                    .Where(j => j.TimeId == partida.TimeVisitanteId
                             && j.Posicao != Posicao.Goleiro)
                    .ToList();

                if (possiveisVisitantes.Any())
                {
                    var escolhido = possiveisVisitantes[_rng.Next(possiveisVisitantes.Count)];
                    db.EstatisticasJogos.Add(new EstatisticaJogo
                    {
                        PartidaId = partida.Id,
                        JogadorId = escolhido.ID,
                        Gols = partida.GolsVisitante.Value
                    });
                }
            }
            db.SaveChanges();
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

            var partidas = new List<Partida>();
            int n = times.Count;           // 20
            int rounds = n - 1;            // 19 rodadas na primeira perna
            int perRound = n / 2;          // 10 jogos por rodada
            var teamIds = times.Select(t => t.Id).ToList();

            // 1ª perna
            for (int r = 0; r < rounds; r++)
            {
                for (int i = 0; i < perRound; i++)
                {
                    int h = (i % 2 == 0) ? teamIds[i] : teamIds[n - 1 - i];
                    int a = (i % 2 == 0) ? teamIds[n - 1 - i] : teamIds[i];

                    partidas.Add(new Partida
                    {
                        DataPartida = DateTime.Now.Date.AddDays(r),
                        TimeMandanteId = h,
                        TimeVisitanteId = a
                    });
                }
                // roda a lista exceto o primeiro elemento
                var last = teamIds.Last();
                teamIds.RemoveAt(n - 1);
                teamIds.Insert(1, last);
            }

            // 2ª perna (returno)
            int firstLegCount = partidas.Count;
            for (int i = 0; i < firstLegCount; i++)
            {
                var orig = partidas[i];
                partidas.Add(new Partida
                {
                    DataPartida = orig.DataPartida.AddDays(rounds),
                    TimeMandanteId = orig.TimeVisitanteId,
                    TimeVisitanteId = orig.TimeMandanteId
                });
            }

            // (2) Agora percorre toda a lista e atribui Round fixo a cada bloco de 10 jogos
            int currentRound = 1;
            int jogoCount = 0;
            foreach (var p in partidas)
            {
                p.Round = currentRound;
                jogoCount++;
                if (jogoCount == perRound)
                {
                    currentRound++;
                    jogoCount = 0;
                }
            }

            // (3) Salva tudo

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
