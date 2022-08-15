using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PGDAC2022MVCApp.Controllers
{
    public class HelpersDemoController : Controller
    {
        // GET: HelpersDemo
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult CustomHelpersView()
        {
            return View();
        }
    }
}