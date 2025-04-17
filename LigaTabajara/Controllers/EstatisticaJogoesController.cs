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
    public class EstatisticaJogoesController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        // GET: /EstatisticaJogoes
        public ActionResult Index(int? rodada)
        {
            // 1) pega as partidas com placar definido
            var partidas = db.Partidas
                             .Where(p => p.GolsMandante.HasValue && p.GolsVisitante.HasValue);

            // 2) filtra por rodada, se houver
            if (rodada.HasValue)
                partidas = partidas.Where(p => p.Round == rodada.Value);

            // 3) monta o grouping de gols por time
            var golsPorTimeIds = partidas
               .SelectMany(p => new[] {
                   new { TimeId = p.TimeMandanteId, Gols = p.GolsMandante.Value },
                   new { TimeId = p.TimeVisitanteId, Gols = p.GolsVisitante.Value }
               })
               .GroupBy(x => x.TimeId)
               .Select(g => new {
                   TimeId = g.Key,
                   TotalGols = g.Sum(x => x.Gols)
               });

            // 4) faz join com a tabela Times para obter o nome
            var golsPorTime = (from gt in golsPorTimeIds
                               join t in db.Times on gt.TimeId equals t.Id
                               orderby gt.TotalGols descending
                               select new TimeGolsVM
                               {
                                   TimeNome = t.Nome,
                                   Gols = gt.TotalGols
                               }).ToList();

            // 5) Artilheiros (já filtrados por rodada ou geral)
            var artilheiros = db.EstatisticasJogos
                .Where(e => !rodada.HasValue || e.Partida.Round == rodada.Value)
                .GroupBy(e => new { e.Jogador.ID, e.Jogador.Name, e.Jogador.Time.Nome })
                .Select(g => new ArtilheiroVM
                {
                    JogadorNome = g.Key.Name,
                    TimeNome = g.Key.Nome,
                    Gols = g.Sum(x => x.Gols)
                })
                .OrderByDescending(a => a.Gols)
                .ToList();

            // pega todas as partidas com placar definido
            var partidasComResultado = db.Partidas
                .Where(p => p.GolsMandante.HasValue && p.GolsVisitante.HasValue);

            // pega todas as partidas da rodada (disputadas ou não)
            var partidasDaRodada = rodada.HasValue
                ? db.Partidas.Where(p => p.Round == rodada.Value)
                : db.Partidas;
            // 6) Mensagem para rodada ainda não atualizada
            if (rodada.HasValue &&
             db.Partidas.Any(p => p.Round == rodada.Value) &&
             !partidasComResultado.Any(p => p.Round == rodada.Value))
            {
                ViewBag.Info = $"Rodada {rodada} ainda não atualizada.";
            }

            // 7) monta o ViewModel
            var vm = new EstatisticasIndexVM
            {
                Rodada = rodada,
                TimeGols = golsPorTime,
                Artilheiros = artilheiros
            };

            return View(vm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}