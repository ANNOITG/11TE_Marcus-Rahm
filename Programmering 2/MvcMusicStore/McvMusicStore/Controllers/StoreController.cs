using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using McvMusicStore.Models;

namespace McvMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre{ name = "Disco"},
                new Genre{ name = "Jazz"},
                new Genre{ name = "Rock"}
            };
            return View(genres);
        }

        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { name = genre };
            return View(genreModel);
        }

        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id };
            return View(album);
        }

    }
}
