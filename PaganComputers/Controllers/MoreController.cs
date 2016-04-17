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
            ViewBag.Message = "More.";

            return View();
        }

        public ActionResult DevLinks()
        {
            ViewBag.Message = "Dev Links.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Portfolio.";

            return View();
        }
    }
}