using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaganComputers.Controllers
{
    public class MoreController : Controller
    {
        // GET: More
        public ActionResult Index()
        {
            ViewBag.Title = "More";
            ViewBag.Message = "";
            return View();
        }

        public ActionResult DevLinks()
        {
            ViewBag.Title = "Development Links";
            ViewBag.Message = "";
            return View();
        }

        public ActionResult Portfolio()
        {

            ViewBag.Title = "Portfolio";
            ViewBag.Message = "";
            return View();
        }

        public ActionResult VW()
        {
            ViewBag.Title = "1972 VW restoration project";
            ViewBag.Message = "";
            return View();
        }
    }
}