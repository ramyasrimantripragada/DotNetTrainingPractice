using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WordVoyagerMVC.Models;

namespace WordVoyagerMVC.Controllers
{
    public class TagsController : Controller
    {
        ServicesContext sc = new ServicesContext();
        // GET: Tags
        public ActionResult Index()
        {
            var tags = sc.tags;
            return View(tags.ToList());
        }

        // GET: Tags/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TagModel model = sc.tags.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: Tags/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TagModel tagModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sc.tags.Add(tagModel);
                    sc.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tagModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Tags/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TagModel tag = sc.tags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // POST: Tags/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TagModel tagModel)
        {
            if (ModelState.IsValid)
            {
                sc.Entry(tagModel).State = EntityState.Modified;
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tagModel);
        }

        // GET: Tags/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TagModel tag = sc.tags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);

        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            TagModel tag = sc.tags.Find(id);
            sc.tags.Remove(tag);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
