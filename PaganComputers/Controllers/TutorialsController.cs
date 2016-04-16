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
            ViewBag.Message = "Tutorials.";

            return View();
        }

        public ActionResult Git()
        {
            ViewBag.Message = "GIT.";

            return View();
        }

        public ActionResult Linux()
        {
            ViewBag.Message = "Linux.";

            return View();
        }

        public ActionResult VM()
        {
            ViewBag.Message = "VM.";

            return View();
        }

    }
}