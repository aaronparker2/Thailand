using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thailand.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "2016 News about the Foundation";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pop Up at Bliss 3 - Saturday 6 May 2017";

            return View();
        }
    }
}