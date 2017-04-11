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
    //[TestClass]
    //public class HomeControllerTest
    //{
    //    [TestMethod]
    //    public void Index()
    //    {
    //        // Arrange
    //        HomeController controller = new HomeController();

    //        // Act
    //        ViewResult result = controller.Index() as ViewResult;

    //        // Assert
    //        Assert.IsNotNull(result);
    //    }

    //    [TestMethod]
    //    public void About()
    //    {
    //        // Arrange
    //        HomeController controller = new HomeController();

    //        // Act
    //        ViewResult result = controller.About() as ViewResult;

    //        // Assert
    //        Assert.AreEqual("Your application description page.", result.ViewBag.Message);
    //    }

    //    [TestMethod]
    //    public void Contact()
    //    {
    //        // Arrange
    //        HomeController controller = new HomeController();

    //        // Act
    //        ViewResult result = controller.Contact() as ViewResult;

    //        // Assert
    //        Assert.IsNotNull(result);
    //    }
    //}
    [TestClass]
    public class UnitTest1
    {
        //List<Restaurant> restaurants = new List<Restaurant>();
        //List<Order> orders = new List<Order>();
        //RestaurantModels rest1 = new RestaurantModels();
        //RestaurantModels rest2 = new RestaurantModels();
        //RestaurantModels rest3 = new RestaurantModels();

        //Suburb burb1 = new Suburb();
        //Suburb burb2 = new Suburb();
        //Suburb burb3 = new Suburb();

        //Order order1 = new Order();
        //Order order2 = new Order();
        //Order order3 = new Order();


        //[TestInitialize]
        //public void Initialize()
        //{

        //    order1.OrderID = 1;
        //    order1.OrderDate = Convert.ToDateTime("12/01/2017");
        //    orders.Add(order1);
        //    order2.OrderID = 2;
        //    order2.OrderDate = Convert.ToDateTime("12/02/2017");
        //    orders.Add(order2);
        //    order3.OrderID = 3;
        //    order3.OrderDate = Convert.ToDateTime("12/03/2017");
        //    orders.Add(order3);

        //    burb1.Name = "Sydney";
        //    burb1.PostCode = 2000;
        //    burb2.Name = "Newtown";
        //    burb2.PostCode = 2001;
        //    burb3.Name = "Glebe";
        //    burb3.PostCode = 2002;

        //    rest1 = new RestaurantModels()
        //    {
        //        ID = 1,
        //        Name = "A",
        //        Rating = 0,
        //        Orders = orders,
        //        Suburb = burb1,
        //        Latitude = "-33.8667735",
        //        Longitude = "151.204251"
        //    };
        //    rest2 = new RestaurantModels()
        //    {
        //        ID = 2,
        //        Name = "B",
        //        Rating = 0,
        //        Orders = orders,
        //        Suburb = burb2,
        //        Latitude = "-33.896735",
        //        Longitude = "151.1776257"
        //    };
        //    rest3 = new RestaurantModels()
        //    {
        //        ID = 3,
        //        Name = "C",
        //        Rating = 0,
        //        Orders = orders,
        //        Suburb = burb3,
        //        Latitude = "-33.8794995",
        //        Longitude = "151.1866586"
        //    };

        //    restaurants.Add(rest1);
        //    restaurants.Add(rest2);
        //    restaurants.Add(rest3);
        //}
        
  

        [TestMethod]
        public void ReturnsListofRestaurants()
        {
            // Arrange
            Restaurant restController = new Restaurant();

            //Act
            //List<Restaurant> t = restController.GetListRestaurants() as ViewResult;
            //var restaurants = result.Model as List<Restaurant>;

            //Assert
            //Assert.AreEqual(restaurants.Count, "3");
            
            
        }
    }
}
