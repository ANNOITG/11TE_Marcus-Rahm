using ForumDelux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumDelux.Controllers
{
    public class ForumController : Controller
    {
        ForumDB forumDB = new ForumDB();
        //
        // GET: /Forum/

        public ActionResult Index()
        {
            var categorys = forumDB.Categorys.Include("Topics").ToList();
            return View(categorys);
        }

        public ActionResult Category(string category)
        {
            var categoryModel = forumDB.Categorys.Include("Topics")
                .Single(c => c.Name == category);
            return View(categoryModel);
        }
        public ActionResult Topic(string topic)
        {
            var topicModel = forumDB.Topics.Single(t => t.Name == topic);
            return View(topicModel);
        }

    }
}
