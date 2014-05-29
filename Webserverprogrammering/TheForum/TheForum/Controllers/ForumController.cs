using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheForum.Models;

namespace TheForum.Controllers
{
    public class ForumController : Controller
    {
        ForumDbContext forumDB = new ForumDbContext();
        //
        // GET: /Forum/

        public ActionResult Index()
        {
            var categorys = forumDB.Categorys.ToList();
            return View(categorys);
        }

    }
}
