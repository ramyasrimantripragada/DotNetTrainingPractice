using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WordVoyagerMVC.Entities;
using WordVoyagerMVC.Models;

namespace WordVoyagerMVC.Controllers
{
    public class UsersController : Controller
    {
        private ServicesContext sc = new ServicesContext();
        // GET: Users
        public ActionResult Index()
        {
            var users = sc.users;
            return View(users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsersModel model = sc.users.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsersModel usersModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sc.users.Add(usersModel);
                    sc.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(usersModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsersModel user = sc.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UsersModel usersModel)
        {
            if (ModelState.IsValid)
            {
                sc.Entry(usersModel).State = EntityState.Modified;
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usersModel);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsersModel user = sc.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            UsersModel user = sc.users.Find(id);
            sc.users.Remove(user);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
