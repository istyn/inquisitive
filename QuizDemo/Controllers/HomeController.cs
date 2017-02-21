using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizDemo.Controllers
{
    public class HomeController : Controller
    {
        //[Route("exam")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demonstration of a ASP.NET MVC app using Entity Framework and AJAX.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Isaac Styles</br>isaacstyles92@gmail.com";

            return View();
        }
    }
}