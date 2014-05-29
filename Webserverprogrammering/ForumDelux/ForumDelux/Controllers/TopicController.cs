using ForumDelux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumDelux.Controllers
{
    public class TopicController : Controller
    {
        private ForumDB DB = new ForumDB();
        //
        // GET: /Topic/

        public ActionResult Index()
        {   
            
            return View();
        }

        //
        // GET: /Topic/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Topic/Create

        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(DB.Categorys, "CategoryId", "Name");
            return View();
        } 

        //
        // POST: /Topic/Create

        [HttpPost]
        public ActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                DB.Topics.Add(topic);
                DB.SaveChanges();
                return Redirect("/Forum/Index");
            }

            ViewBag.CategoryId = new SelectList(DB.Categorys, "Id", "Name",topic.CategoryId);
            return View(topic);
        }
        
        //
        // GET: /Topic/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Topic/Edit/5

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
        // GET: /Topic/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Topic/Delete/5

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
