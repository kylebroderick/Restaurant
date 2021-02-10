using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            RestaurantRanking = rank;
        }

        [Required(ErrorMessage = "Ranking is required")]
        public int RestaurantRanking { get; }

        [Required(ErrorMessage = "Name is required")]
        public string RestaurantName { get; set; }

        public string? FavoriteDish { get; set; } = "It's all tasty!";

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string? Phone { get; set; }

        public string? Link { get; set; } = "Coming soon.";



        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Taco Bell",
                FavoriteDish = "Burrito",
                Address = "777 N 888 W Provo",
                Phone = "8888888888",
                Link = "tacobell.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Tucanos",
                FavoriteDish = "Parmesean Chicken",
                Address = "333 N 222 W Provo",
                Phone = "5555555555",
                Link = "tucanos.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Pita Pit",
                FavoriteDish = "Greek Gyro",
                Address = "123 N 456 W Provo",
                Phone = "1111111111",
                Link = "pitapit.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Noodles and Company",
                FavoriteDish = "Pesto Pasta",
                Address = "789 N 678 W Provo",
                Phone = "9999999999",
                Link = "noodlesandcompany.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Five Sushi Bros",
                FavoriteDish = "Band Manager",
                Address = "829 N 193 W Provo",
                Phone = "1234567890",
                Link = "fivesushibros.com"
            };



            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
