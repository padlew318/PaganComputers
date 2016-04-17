using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaganComputers.Controllers
{
    public class TutorialsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Tutorials";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Git()
        {
            ViewBag.Title = "Git.";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Linux()
        {
            ViewBag.Title = "Linux.";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult VM()
        {
            ViewBag.Title = "Virtual machines.";
            ViewBag.Message = "Your application description page.";
            return View();
        }

    }
}