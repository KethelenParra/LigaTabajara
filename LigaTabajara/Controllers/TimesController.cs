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
    public class TimesController : Controller
    {
        private LigaTabajaraContext db = new LigaTabajaraContext();

        // GET: Times
        public ActionResult Index()
        {
            var times = db.Times
                           .Include(t => t.ComissoesTecnicas)
                           .Include(t => t.Jogadores)
                           .ToList();
            return View(times);
        }

        // GET: Times/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time time = db.Times.Find(id);
            if (time == null)
            {
                return HttpNotFound();
            }
            return View(time);
        }

        // GET: Times/Create
        public ActionResult Create()
        {
            // se já houver 20 times, bloqueia até a exibição do form
            if (db.Times.Count() >= 20)
            {
                TempData["Error"] = "Já existem 20 times cadastrados; não é possível adicionar mais.";
                return RedirectToAction("Index");
            }
            return View();
        }

        // POST: Times/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Cidade,Estado,DataFundacao,Estadio,CapacidadeEstadio,CorUniformePrimario,CorUniformeSecuntario,StatusTime")] Time time)
        {
            // valida limite de 20 antes de tudo
            if (db.Times.Count() >= 20)
            {
                ModelState.AddModelError("", "Limite de 20 times atingido; não é possível cadastrar mais.");
            }

            // valida nome único
            if (db.Times.Any(t => t.Nome.Equals(time.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                ModelState.AddModelError("Nome", "Já existe um time cadastrado com este nome.");
            }

            if (ModelState.IsValid)
            {
                db.Times.Add(time);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(time);
        }

        // GET: Times/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time time = db.Times.Find(id);
            if (time == null)
            {
                return HttpNotFound();
            }
            return View(time);
        }

        // POST: Times/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Cidade,Estado,DataFundacao,Estadio,CapacidadeEstadio,CorUniformePrimario,CorUniformeSecuntario,StatusTime")] Time time)
        {
            if (db.Times.Any(t => t.Id != time.Id
                                && t.Nome.Equals(time.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                ModelState.AddModelError("Nome", "Já existe um outro time cadastrado com este nome.");
            }
            if (ModelState.IsValid)
            {
                db.Entry(time).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        // GET: Times/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time time = db.Times.Find(id);
            if (time == null)
            {
                return HttpNotFound();
            }
            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Time time = db.Times.Find(id);
            db.Times.Remove(time);
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
