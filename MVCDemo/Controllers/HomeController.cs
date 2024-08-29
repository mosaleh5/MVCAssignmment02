using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); 
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Google()
        {
            return Redirect("https://www.google.co.uk/");
        }
        public ActionResult ContactUs() 
        {
            return View();
        } 
        public ActionResult Privacy() 
        {
            return View();
        }

    }

}
