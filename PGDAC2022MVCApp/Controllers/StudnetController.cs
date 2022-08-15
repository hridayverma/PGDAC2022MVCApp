using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PGDAC2022MVCApp.Controllers
{
    public class StudnetController : Controller
    {
        // GET: Studnet
       // [Route("students/{id}/courses")]
        public ViewResult GetStudentCourses(int id)
        {
            List<string> courseList=null;
            if (id == 1)
            {
                courseList = new List<string>() {"C++","Java","PHP","Python" };
            }
            else if (id == 2)
            {
                courseList = new List<string>() { "ML", "AI", "JS", "React","Agular" };
            }
            else if (id == 3)
            {
                courseList = new List<string>() { "ML", "AI", "JS", "ASP.NET MVC", "ASP.NET" };
            }
            else if (id == 4)
            {
                courseList = new List<string>() { "ML", "AI", "JS", "J2EE", "C#" };
            }
            else
                courseList = new List<string>() {  "AI", "JS", "React", "Agular" };


            ViewBag.Courses = courseList;

            return View();
        }
    }
}