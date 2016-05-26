using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CGFP.Models;

namespace CGFP.Controllers
{
    public class ProjectsModelsController : Controller
    {
        private CGFPContext db = new CGFPContext();

        // GET: ProjectsModels
        public ActionResult Index()
        {
            return View(db.ProjectsModels.ToList());
        }

        // GET: ProjectsModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectsModel projectsModel = db.ProjectsModels.Find(id);
            if (projectsModel == null)
            {
                return HttpNotFound();
            }
            return View(projectsModel);
        }

        // GET: ProjectsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ProjectName,DescripProject,Image,GitAddress")] ProjectsModel projectsModel)
        {
            if (ModelState.IsValid)
            {
                db.ProjectsModels.Add(projectsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectsModel);
        }

        // GET: ProjectsModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectsModel projectsModel = db.ProjectsModels.Find(id);
            if (projectsModel == null)
            {
                return HttpNotFound();
            }
            return View(projectsModel);
        }

        // POST: ProjectsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ProjectName,DescripProject,Image,GitAddress")] ProjectsModel projectsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectsModel);
        }

        // GET: ProjectsModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectsModel projectsModel = db.ProjectsModels.Find(id);
            if (projectsModel == null)
            {
                return HttpNotFound();
            }
            return View(projectsModel);
        }

        // POST: ProjectsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectsModel projectsModel = db.ProjectsModels.Find(id);
            db.ProjectsModels.Remove(projectsModel);
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
