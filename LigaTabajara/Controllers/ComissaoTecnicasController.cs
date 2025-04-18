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
    public class ComissaoTecnicasController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        // GET: ComissaoTecnicas
        public ActionResult Index(string searchName, Cargo? selectedCargo)
        {
            var vm = new ComissaoTecnicaIndexViewModel();

            // 1) popula dropdown de cargos (enum)
            vm.Cargos = Enum.GetValues(typeof(Cargo))
                            .Cast<Cargo>()
                            .Select(c => new SelectListItem
                            {
                                Text = c.ToString(),
                                Value = ((int)c).ToString(),
                                Selected = (c == selectedCargo)
                            })
                            .ToList();

            // 2) mantém valores atuais
            vm.SearchName = searchName;
            vm.SelectedCargo = selectedCargo;

            // 3) monta a query e aplica filtros
            var query = db.ComissoesTecnicas
                          .Include(m => m.Time)
                          .AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchName))
                query = query.Where(m => m.Nome.Contains(searchName));

            if (selectedCargo.HasValue)
                query = query.Where(m => m.Cargo == selectedCargo.Value);

            vm.Membros = query
                .OrderBy(m => m.Nome)
                .ToList();

            return View(vm);
        }

        // GET: ComissaoTecnicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: ComissaoTecnicas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Cargo,DataNascimento,TimeId")] ComissaoTecnica comissaoTecnica)
        {
            // 1) duplicidade Nome+DataNascimento+Cargo
            bool existeMesmo = db.ComissoesTecnicas.Any(ct =>
                ct.Nome == comissaoTecnica.Nome
                && DbFunctions.TruncateTime(ct.DataNascimento) == comissaoTecnica.DataNascimento.Date
                && ct.Cargo == comissaoTecnica.Cargo);
            if (existeMesmo)
                ModelState.AddModelError("", "Já existe membro com esse Nome, Data de Nascimento e Cargo.");

            // 2) cargo único por Time
            bool cargoJaUsado = db.ComissoesTecnicas.Any(ct =>
                ct.TimeId == comissaoTecnica.TimeId
                && ct.Cargo == comissaoTecnica.Cargo);
            if (cargoJaUsado)
                ModelState.AddModelError("Cargo", "Este time já possui alguém exercendo este Cargo.");

            // 3) no máximo 6 membros por Time
            int countMembros = db.ComissoesTecnicas.Count(ct => ct.TimeId == comissaoTecnica.TimeId);
            if (countMembros >= 6)
                ModelState.AddModelError("", "Este time já atingiu o número máximo de 6 membros na comissão técnica.");

            if (ModelState.IsValid)
            {
                db.ComissoesTecnicas.Add(comissaoTecnica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnicas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Cargo,DataNascimento,TimeId")] ComissaoTecnica comissaoTecnica)
        {
            // 1) duplicidade Nome+DataNascimento+Cargo
            bool existeMesmo = db.ComissoesTecnicas.Any(ct =>
                ct.Nome == comissaoTecnica.Nome
                && DbFunctions.TruncateTime(ct.DataNascimento) == comissaoTecnica.DataNascimento.Date
                && ct.Cargo == comissaoTecnica.Cargo);
            if (existeMesmo)
                ModelState.AddModelError("", "Já existe membro com esse Nome, Data de Nascimento e Cargo.");

            // 2) cargo único por Time
            bool cargoJaUsado = db.ComissoesTecnicas.Any(ct =>
                ct.TimeId == comissaoTecnica.TimeId
                && ct.Cargo == comissaoTecnica.Cargo);
            if (cargoJaUsado)
                ModelState.AddModelError("Cargo", "Este time já possui alguém exercendo este Cargo.");

            // 3) no máximo 6 membros por Time
            int countMembros = db.ComissoesTecnicas.Count(ct => ct.TimeId == comissaoTecnica.TimeId);
            if (countMembros >= 6)
                ModelState.AddModelError("", "Este time já atingiu o número máximo de 6 membros na comissão técnica.");

            if (ModelState.IsValid)
            {
                db.Entry(comissaoTecnica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            db.ComissoesTecnicas.Remove(comissaoTecnica);
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
