using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

namespace Forum.Controllers
{
    public class ForumManagerController : Controller
    {
        private ForumDbContext db = new ForumDbContext();
        //
        // GET: /ForumManager/

        public ActionResult Index()
        {
            var category = db.Categorys.Include(i => i.topic);
            return View(category.ToList());
        }

        //
        // GET: /ForumManager/Details/5

        public ActionResult Details(int id)
        {
            Category category = db.Categorys.Find(id);
            return View(category);
        }

        //
        // GET: /ForumManager/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ForumManager/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ForumManager/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ForumManager/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ForumManager/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ForumManager/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
