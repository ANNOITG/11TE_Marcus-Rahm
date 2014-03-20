using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class ForumController : Controller
    {
        ForumDbContext forumDB = new ForumDbContext();
        //
        // GET: /Forum/

        public ActionResult Index()
        {
            var category = forumDB.categorys.ToList();
            return View(category);
        }

        public ActionResult Topics(string category)
        {
            var TopicModel = forumDB.categorys.Include("topic")
                .Single(g => g.name == category);
            return View(TopicModel);
        }

    }
}
