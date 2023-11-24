using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edithtour.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        public ActionResult TourInSide()
        {
            return View();
        }
        public ActionResult Plane()
        {
            return View();
        }
    }
}