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
        public ActionResult List()
        {
            string userLatitude = "-33.897840";
            string userLongitude = "151.178905";
            Restaurant rest = new Restaurant();
            List<Restaurant> rests = rest.GetListRestaurants();

            List<Restaurant> sortedlist = Helper.SortList(rests, userLatitude, userLongitude);

            return View(sortedlist);
        }
        
    }
}