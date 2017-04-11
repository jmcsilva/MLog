using MLFoodDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLFoodDev.Controllers
{
    public class RestaurantsController : Controller
    {
        private List<Restaurant> restList = new List<Restaurant>();

        // GET: Restaurants
        public ActionResult Index()
        {
            Restaurant rest = new Restaurant();
            List<Restaurant> rests = rest.GetListRestaurants();
            return View(rests);
        }

        //public ActionResult List()
        //{
        //    Restaurant rest = new Restaurant();
        //    List<Restaurant> rests = rest.GetListRestaurants();
        //    return View(rests);
        //}
    }
}