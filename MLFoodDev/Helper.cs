using MLFoodDev.Models;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;

namespace MLFoodDev
{
    public class Helper
    {
        public static decimal GetOrdersAverage(List<Order> orders)
        {
            List<decimal> arrayValue = new List<decimal>();

            foreach (Order ord in orders)
            {
                arrayValue.Add(ord.Total);
            }

            return decimal.Round(GetAverage(arrayValue.ToArray()), 2);
        }

        public static decimal GetAverage(decimal[] arr)
        {
            decimal result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return Convert.ToDecimal(result / arr.Length);
        }

        internal static List<Restaurant> SortList(List<Restaurant> rests, string userLat, string userLong)
        {
            foreach (Restaurant rest in rests)
            {
                rest.AverageTotalOrder = GetOrdersAverage(rest.Orders);

                GetAgeOrder(rest);
                GetDistanceToUser(rest, userLat,userLong);

            }

            var sortedList = rests.OrderByDescending(o => o.Rating).ThenByDescending(o => o.AgeDateRanking).ThenBy(o => o.AverageTotalOrder).ThenByDescending(o => o.DistancetoUser);
            return sortedList.ToList(); 
        }

        public static List<Restaurant> SortListByRating(List<Restaurant> rests)
        {
            var sort = rests.OrderByDescending(o => o.Rating).ToList();

            return sort;
        }

        public static List<Restaurant> SortListByPrice(List<Restaurant> rests)
        {
            var sort = rests.OrderBy(o => o.AverageTotalOrder).ToList();

            return sort;
        }

        public static Restaurant GetAgeOrder(Restaurant rest)
        {
            //Establishing last 2 months, the more dates inside time frame the better the ranking
            
            foreach (Order ord in rest.Orders)
            {
                if (ord.OrderDate >= DateTime.Now.AddDays(-60))
                {
                    rest.AgeDateRanking++;
                }
            }
            
            return rest;
        }

        public static Restaurant GetDistanceToUser(Restaurant rest, string userLat, string userLong)
        {
           
            var restCoords = new GeoCoordinate(Convert.ToDouble(rest.Latitude), Convert.ToDouble(rest.Longitude));
            var userCoords = new GeoCoordinate(Convert.ToDouble(userLat), Convert.ToDouble(userLong));

            rest.DistancetoUser = restCoords.GetDistanceTo(userCoords);
           

            return rest;
        }
    }
}