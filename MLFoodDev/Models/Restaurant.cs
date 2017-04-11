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
        public int NoOrders { get; set; }
        public decimal AverageTotalOrder { get; set; }
        public int AgeDateRanking { get; set; }
        public double DistancetoUser { get; set; }



        public List<Restaurant> GetListRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();

            List<Order> ordersList1 = new List<Order>();
            List<Order> ordersList2 = new List<Order>();
            List<Order> ordersList3 = new List<Order>();
            Restaurant rest1 = new Restaurant();
            Restaurant rest2 = new Restaurant();
            Restaurant rest3 = new Restaurant();

            Suburb burb1 = new Suburb();
            Suburb burb2 = new Suburb();
            Suburb burb3 = new Suburb();

            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();
            Order order4 = new Order();
            Order order5 = new Order();
            Order order6 = new Order();
            Order order7 = new Order();
            Order order8 = new Order();
            Order order9 = new Order();

            order1.OrderID = 1;
            order1.OrderDate = Convert.ToDateTime("4/12/2016");
            order1.Total = 125;
            ordersList1.Add(order1);

            order2.OrderID = 2;
            order2.OrderDate = Convert.ToDateTime("12/03/2017");
            order1.Total = 80;
            ordersList1.Add(order2);

            order3.OrderID = 3;
            order3.OrderDate = Convert.ToDateTime("5/04/2017");
            order3.Total = 75;
            ordersList1.Add(order3);
            
            order4.OrderID = 1;
            order4.OrderDate = Convert.ToDateTime("6/02/2017");
            order4.Total = 125;
            ordersList2.Add(order4);

            order5.OrderID = 2;
            order5.OrderDate = Convert.ToDateTime("2/11/2016");
            order5.Total = 80;
            ordersList2.Add(order5);

            order6.OrderID = 3;
            order6.OrderDate = Convert.ToDateTime("23/12/2016");
            order6.Total = 75;

            ordersList2.Add(order6);
            
            order7.OrderID = 1;
            order7.OrderDate = Convert.ToDateTime("6/04/2017");
            order7.Total = 40;
            ordersList3.Add(order7);

            order8.OrderID = 2;
            order8.OrderDate = Convert.ToDateTime("2/11/2016");
            order8.Total = 55;
            ordersList3.Add(order8);

            order9.OrderID = 3;
            order9.OrderDate = Convert.ToDateTime("23/12/2016");
            order9.Total = 35;
            ordersList3.Add(order9);

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
                Rating = 5,
                Orders = ordersList1,
                Suburb = burb1,
                Latitude = "-33.8667735",
                Longitude = "151.204251",
                AverageTotalOrder = Helper.GetOrdersAverage(ordersList1),
                NoOrders = ordersList1.Count,
                AgeDateRanking = 0,
                DistancetoUser = 0
            };
            rest2 = new Restaurant()
            {
                ID = 2,
                Name = "B",
                Rating = 4,
                Orders = ordersList2,
                Suburb = burb2,
                Latitude = "-33.896735",
                Longitude = "151.1776257",
                AverageTotalOrder = Helper.GetOrdersAverage(ordersList2),
                NoOrders = ordersList2.Count,
                AgeDateRanking = 0,
                DistancetoUser = 0
            };  
            rest3 = new Restaurant()
            {
                ID = 3,
                Name = "C",
                Rating = 3,
                Orders = ordersList3,
                Suburb = burb3,
                Latitude = "-33.8794995",
                Longitude = "151.1866586",
                AverageTotalOrder = Helper.GetOrdersAverage(ordersList3),
                NoOrders = ordersList3.Count,
                AgeDateRanking = 0,
                DistancetoUser = 0
            };

            restaurants.Add(rest1);
            restaurants.Add(rest2);
            restaurants.Add(rest3);

            return restaurants;
        }
    }

}