using Restaurant.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;

namespace Restaurant.Controllers
{
    public class RestaurantController : Controller
    {

        // GET: Restaurant
        public ActionResult Index()
        {
            //Service1Client o = new Service1Client();
            //var restaurants = o.GetAll().ToList();
            //return Json(new { data = restaurants,}, JsonRequestBehavior.AllowGet);
            return View();
        }
        public ActionResult GetList()
        {
            //Server side parameters
            int start = Convert.ToInt32(Request["start"]);
            int length = Convert.ToInt32(Request["length"]);
            string searchValue = Request["search[value]"];
            string sortColumnName = Request["columns[" + Request["order[0][column]"] + "][name]"];
            string sortDirection = Request["order[0][dir]"];


            Service1Client o = new Service1Client();
            var restaurants = o.GetAll().ToList();
            int totalrows = restaurants.Count;
            //Search
            if (!string.IsNullOrEmpty(searchValue)) //filter
            {
                restaurants = restaurants.Where(x => x.Name.ToLower().Contains(searchValue.ToLower())
                || x.CuisineType.ToString().Contains(searchValue.ToLower())).ToList();
            }
            int totalrowsafterfiltering = restaurants.Count;
            //Sorting
            restaurants = restaurants.OrderBy(sortColumnName + " " + sortDirection).ToList();

            //Paging
            restaurants = restaurants.Skip(start).Take(length).ToList();

            return Json(new { data = restaurants, draw = Request["draw"], recordsTotal = totalrows, recordsFiltered = totalrowsafterfiltering }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
         public ActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Restaurants restaurant)
        {
            Service1Client o = new Service1Client();
            if (ModelState.IsValid)
            {
                o.Add(restaurant);
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            Service1Client o = new Service1Client();
            var model = o.Get(Id);
            if (model == null)
            {
                return RedirectToAction("NotFound");
            }
            return View(model);
        }
        public ActionResult Delete(int Id)
        {
            Service1Client o = new Service1Client();
            var modelDelete = o.Get(Id);
            if (modelDelete == null)
            {
                return RedirectToAction("NotFound");
            }
            return View(modelDelete);
        }
        [HttpPost]
        public ActionResult Delete(Restaurants restaurant)
        {
            Service1Client o = new Service1Client();
            o.Remove(restaurant);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Service1Client o = new Service1Client();
            var modelEdit = o.Get(Id);
            if (modelEdit == null)
            {
                return RedirectToAction("NotFound");
            }
            return View(modelEdit);
        }
        [HttpPost]
        public ActionResult Edit(Restaurants restaurant)
        {
            Service1Client o = new Service1Client();
            o.Update(restaurant);
            return RedirectToAction("Details", new {id = restaurant.Id });
        }

        public ActionResult NotFound()
        {

            return View();
        }

    }
}