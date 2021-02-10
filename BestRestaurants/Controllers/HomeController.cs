using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TopFive()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add(string.Format("#{0}: {1}, {2}, {3}, {4}, {5}", r.RestaurantRanking, r.RestaurantName, r.FavoriteDish, r.Address, r.Phone, r.Link));
            }

            return View(restaurantList);
        }


        [HttpGet]
        public IActionResult EnterRestaurant()
        {
            return View();
        }


        [HttpPost]
        public IActionResult EnterRestaurant(EnterRestaurant restaurant)
        {

            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurant);
                return View("Confirmation", restaurant);
            }

            else
            {
                return View();
            }
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.Restaurants);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
