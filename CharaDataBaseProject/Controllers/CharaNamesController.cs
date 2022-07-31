using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CharaDataBaseProject.Models;

namespace CharaDataBaseProject.Controllers
{
    public class CharaNamesController : Controller
    {
        private ContosoUniversityDataEntities db = new ContosoUniversityDataEntities();

        // GET: CharaNames
        public ActionResult Index()
        {
            return View(db.CharaName.ToList());
        }

        // GET: CharaNames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharaName charaName = db.CharaName.Find(id);
            if (charaName == null)
            {
                return HttpNotFound();
            }
            return View(charaName);
        }

        // GET: CharaNames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CharaNames/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CharaID,Name")] CharaName charaName)
        {
            if (ModelState.IsValid)
            {
                db.CharaName.Add(charaName);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(charaName);
        }

        // GET: CharaNames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharaName charaName = db.CharaName.Find(id);
            if (charaName == null)
            {
                return HttpNotFound();
            }
            return View(charaName);
        }

        // POST: CharaNames/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CharaID,Name")] CharaName charaName)
        {
            if (ModelState.IsValid)
            {
                db.Entry(charaName).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(charaName);
        }

        // GET: CharaNames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharaName charaName = db.CharaName.Find(id);
            if (charaName == null)
            {
                return HttpNotFound();
            }
            return View(charaName);
        }

        // POST: CharaNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CharaName charaName = db.CharaName.Find(id);
            db.CharaName.Remove(charaName);
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
