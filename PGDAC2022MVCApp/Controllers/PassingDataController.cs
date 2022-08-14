using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PGDAC2022MVCApp.Controllers
{
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult Index()
        {
            return View();
        }
        //Action Method for using parameter 
        [HttpPost]
        public string Index(string Id,string name,string Salary)
        {
            return $"Data using Parameters:{Id} ,{name}, {Salary}";
        }
        //Action method for Request method
        [HttpPost]
        public string DataUsingRequest() {
            //Request.
            return $"Data using Request:{Request["Id"]} ,{Request["Name"]}, {Request["Salary"]}";
        }

        //Action Method using FormCollection
        [HttpPost]
        public string DataUsingForm(FormCollection form) {

            return $"Data using FormCollection:{form["Id"]} ,{form["Name"]}, {form["Salary"]}";

        }

        //Action Methods for Form Using Strongly Binding
        public ViewResult StronglyBinding() {

            return View();
        }

        [HttpPost]
        public string StronglyBinding(PGDAC2022MVCApp.Models.Employee employee)
        {

            return $"Data using StronglyBinding:{employee.ID} ,{employee.Name}, {employee.Salary}";
        }


        public ViewResult RazorDemo() {

            return View();
        }
















    }
}