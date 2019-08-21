using System;
using System.Collections.Generic; //NOTE: This is needed to instantiate (collection objects) our list.
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models; //NOTE: This is needed to access the 'Instructor' class in the 'Models' folder.

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - Teh Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            //NOTE: Here we are instantiating an 'Instructor' object and we are assigning it property values.
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Nicson",
                LastName = "Martinez"
            };
            //NOTE: Here we are passing the object to the views method.
            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            //NOTE: Here we are creating a list of instructors.
            List<Instructor> instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Calendar"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                }
            };

            //NOTE: Here we are passing in 'instructors' to the view.
            return View(instructors);
        }
    }
}