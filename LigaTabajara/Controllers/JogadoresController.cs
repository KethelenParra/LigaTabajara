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
    public class JogadoresController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        // GET: Jogadores
        public ActionResult Index(
            string searchName,
            Posicao? SelectedPosicao,
            PePreferido? SelectedPe
        )
        {
            var vm = new JogadorIndexViewModel();

            // popula dropdowns
            vm.Posicoes = Enum.GetValues(typeof(Posicao))
                              .Cast<Posicao>()
                              .Select(p => new SelectListItem
                              {
                                  Text = p.ToString(),
                                  Value = ((int)p).ToString(),
                                  Selected = (p == SelectedPosicao)
                              })
                              .ToList();

            vm.Pes = Enum.GetValues(typeof(PePreferido))
                         .Cast<PePreferido>()
                         .Select(f => new SelectListItem
                         {
                             Text = f.ToString(),
                             Value = ((int)f).ToString(),
                             Selected = (f == SelectedPe)
                         })
                         .ToList();

            // guarda valores atuais
            vm.SearchName = searchName;
            vm.SelectedPosicao = SelectedPosicao;
            vm.SelectedPe = SelectedPe;

            // monta a query
            var query = db.Jogadores.Include(j => j.Time).AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchName))
                query = query.Where(j => j.Name.Contains(searchName));

            if (SelectedPosicao.HasValue)
                query = query.Where(j => j.Posicao == SelectedPosicao.Value);

            if (SelectedPe.HasValue)
                query = query.Where(j => j.PePreferido == SelectedPe.Value);

            vm.Jogadores = query.OrderBy(j => j.Name).ToList();

            return View(vm);
        }


        // GET: Jogadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // GET: Jogadores/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: Jogadores/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,DataNascimento,Nacionalidade,Posicao,NumCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            // valida: numCamisa único dentro do mesmo time
            bool exists = db.Jogadores.Any(j =>
                j.TimeId == jogador.TimeId &&
                j.NumCamisa == jogador.NumCamisa
            );
            if (exists)
                ModelState.AddModelError("",
                    "Já existe um jogador neste time com esse número de camisa.");

            if (ModelState.IsValid)
            {
                db.Jogadores.Add(jogador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // GET: Jogadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // POST: Jogadores/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,DataNascimento,Nacionalidade,Posicao,NumCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
       
            if (ModelState.IsValid)
            {
                db.Entry(jogador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // GET: Jogadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // POST: Jogadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jogador jogador = db.Jogadores.Find(id);
            db.Jogadores.Remove(jogador);
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
