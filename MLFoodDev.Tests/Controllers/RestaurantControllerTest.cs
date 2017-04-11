using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLFoodDev;
using MLFoodDev.Controllers;

using MLFoodDev.Models;

namespace MLFoodDev.Tests.Controllers
{
    
    [TestClass]
    public class UnitTest1
    {
        RestaurantsController controller = new RestaurantsController();
        Restaurant rest = new Restaurant();

        [TestInitialize]
        public void Init()
        {

        }

        [TestMethod]
        public void ReturnsListofRestaurants()
        {
            // Arrange
            ViewResult result = controller.List() as ViewResult;
            
            //Act
            var restaurants = result.Model as List<Restaurant>;

            //Assert
            Assert.IsTrue(restaurants.Count > 0);
            
            
        }

        [TestMethod]
        public void RankByPrice()
        {
            // Arrange
            List<Restaurant> rests = rest.GetListRestaurants();

            //Act
            List<Restaurant> result = Helper.SortListByPrice(rests);

            //Assert
            Assert.AreEqual(result.First().AverageTotalOrder, result.Min(o => o.AverageTotalOrder));
        }

        [TestMethod]
        public void RankbyRating()
        {
            // Arrange
            List<Restaurant> rests = rest.GetListRestaurants();

            //Act
            List<Restaurant> result = Helper.SortListByRating(rests);

            //Assert
            Assert.AreEqual(result.First().Rating, result.Max(o => o.Rating));
        }

        [TestMethod]
        public void GetMostRecentOrders()
        {
            // Arrange
            Order order1 = new Order { OrderDate = Convert.ToDateTime("4/12/2016")};
            Order order2 = new Order { OrderDate = Convert.ToDateTime("4/04/2017")};
            Order order3 = new Order { OrderDate = Convert.ToDateTime("20/03/2017")};

            List<Order> orders = new List<Order>();
            orders.Add(order1); orders.Add(order2); orders.Add(order3);
            
            Restaurant rest = new Restaurant { Name = "test", AgeDateRanking = 0, Orders = orders };
            
            //Act
            Restaurant result = Helper.GetAgeOrder(rest);

            //Assert
            Assert.IsTrue(result.AgeDateRanking == 2);
        }

        [TestMethod]
        public void GetCloserRestaurant()
        {
            // Arrange
            string userLatitude = "-33.897840";
            string userLongitude = "151.178905";

            Restaurant rest = new Restaurant { Name = "test", DistancetoUser = 0, Latitude = "-33.8667735", Longitude = "151.204251" };
            
            //Act
            Restaurant result = Helper.GetDistanceToUser(rest, userLatitude, userLongitude);

            //Assert
            Assert.IsTrue(result.DistancetoUser == 4175.8380297917492);

        }

        [TestMethod]
        public void CheckAverageTotal()
        {
            //Arrange
            Order order1 = new Order { Total = 120.55m };
            Order order2 = new Order { Total = 80.57m };
            Order order3 = new Order { Total = 65.58m };

            List<Order> orders = new List<Order>();
            orders.Add(order1); orders.Add(order2); orders.Add(order3);
            

            //Act
            decimal result = Helper.GetOrdersAverage(orders);

            //Assert
            Assert.IsTrue(result == 88.9m);
        }
    }
}
