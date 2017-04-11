using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLFoodDev.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Suburb Suburb { get; set; }
        public List<Order> Orders { get; set; }
        public int Rating { get; set; }

        
       


        public List<Restaurant> GetListRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();

            List<Order> orders = new List<Order>();
            Restaurant rest1 = new Restaurant();
            Restaurant rest2 = new Restaurant();
            Restaurant rest3 = new Restaurant();

            Suburb burb1 = new Suburb();
            Suburb burb2 = new Suburb();
            Suburb burb3 = new Suburb();

            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();

            order1.OrderID = 1;
            order1.OrderDate = Convert.ToDateTime("12/01/2017");
            orders.Add(order1);
            order2.OrderID = 2;
            order2.OrderDate = Convert.ToDateTime("12/02/2017");
            orders.Add(order2);
            order3.OrderID = 3;
            order3.OrderDate = Convert.ToDateTime("12/03/2017");
            orders.Add(order3);

            burb1.Name = "Sydney";
            burb1.PostCode = 2000;
            burb2.Name = "Newtown";
            burb2.PostCode = 2001;
            burb3.Name = "Glebe";
            burb3.PostCode = 2002;

            rest1 = new Restaurant()
            {
                ID = 1,
                Name = "A",
                Rating = 0,
                Orders = orders,
                Suburb = burb1,
                Latitude = "-33.8667735",
                Longitude = "151.204251"
            };
            rest2 = new Restaurant()
            {
                ID = 2,
                Name = "B",
                Rating = 0,
                Orders = orders,
                Suburb = burb2,
                Latitude = "-33.896735",
                Longitude = "151.1776257"
            };
            rest3 = new Restaurant()
            {
                ID = 3,
                Name = "C",
                Rating = 0,
                Orders = orders,
                Suburb = burb3,
                Latitude = "-33.8794995",
                Longitude = "151.1866586"
            };

            restaurants.Add(rest1);
            restaurants.Add(rest2);
            restaurants.Add(rest3);

            return restaurants;
        }
    }

}