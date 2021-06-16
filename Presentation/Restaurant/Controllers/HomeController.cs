
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index()
        {
            ServiceReference1.Service1Client o = new ServiceReference1.Service1Client();
            var model = o.GetAll().ToList();
            return View(model);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
