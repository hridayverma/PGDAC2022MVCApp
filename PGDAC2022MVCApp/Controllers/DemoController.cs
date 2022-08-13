using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PGDAC2022MVCApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public string Index()
        {
            return "<b>Welcome to ASP.NET MVC Web Development</b>";
        }
        public string Name()
        {
            return "<b>Welcome :Shinde</b>";
        }
        public string EmpProfile(int ? id)
        {
            string msg = "";
            switch (id)    {
                case 1:
                    msg = "Employee-1 Profile";
                    break;
                case 2:
                    msg = "Employee-2 Profile";
                    break;
                case 3:
                    msg = "Employee-3 Profile";
                    break;
                default:
                    msg = "All Employee profile";
                    break;
            }
            return  msg;
        }

        public ActionResult First()
        {
            return View();//View method call
        }

        public ViewResult SecondView()
        {
            ViewBag.Id = 10;
            ViewBag.Message = "Message from Second Action Method";
            return View("Second");//passing custom view name
        }

        public ViewResult Details() {

            var emp = new PGDAC2022MVCApp.Models.Employee() {
                ID=1000,
                Name="Admin",
                Salary=45600
            };
            return View(emp);//passing emp object as model data to view

        }












    }
}