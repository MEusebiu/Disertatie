using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniLibrary.Controllers
{
    public class FavouritesController : Controller
    {
        // GET: Favourites
        public ActionResult Index()
        {
            return View();
        }
    }
}