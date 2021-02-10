using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BestRestaurants.Models
{
    public static class TempStorage
    {
        private static List<EnterRestaurant> restaurants = new List<EnterRestaurant>();

        public static IEnumerable<EnterRestaurant> Restaurants => restaurants;

        public static void AddRestaurant(EnterRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
