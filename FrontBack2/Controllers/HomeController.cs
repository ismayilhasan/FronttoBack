using FrontBack2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontBack2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
                new Product()
                {
                    Id = 1,
                    ImageUrl = "product-1.jpg",
                    Name = "Men's Dresses",
                    Price = 45

                },
                new Product()
                {
                    Id = 2,
                    ImageUrl = "product-2.jpg",
                    Name = "Men's Dresses",
                    Price = 45

                },
                new Product()
                {
                    Id = 3,
                    ImageUrl = "product-3.jpg",
                    Name = "Boy's Dresses",
                     Price = 5
                },
                new Product()
                {
                    Id = 4,
                    ImageUrl = "product-4.jpg",
                    Name = "Kid's Dresses",
                     Price = 5
                },
                new Product()
                {
                    Id = 5,
                    ImageUrl = "product-5.jpg",
                    Name = "Woman's Dresses",
                     Price = 5
                },
                new Product()
                {
                    Id = 6,
                    ImageUrl = "product-6.jpg",
                    Name = "Baby's Dresses",
                    Price = 25
                }
            };
            var category = new List<Category>
            { 
                new Category()
                {
                    Id=1,
                    Name = "Bags",
                    ImageUrl = "cat-1.jpg"
                },
                 new Category()
                {
                    Id=2,
                    Name = "Woman's dresses",
                    ImageUrl = "cat-2.jpg"
                },
                  new Category()
                {
                    Id=3,
                    Name = "Baby's dresses",
                    ImageUrl = "cat-3.jpg"
                },
                   new Category()
                {
                    Id=4,
                    Name = "Man's dresses",
                    ImageUrl = "cat-4.jpg"
                },
                    new Category()
                {
                    Id=5,
                    Name = "Woman's dresses",
                    ImageUrl = "cat-5.jpg"
                },
                     new Category()
                {
                    Id=6,
                    Name = "Kid's dresses",
                    ImageUrl = "cat-6.jpg"
                }

            };



            var homeViewModel = new HomeViewModel
            {
                Products = products,
                Categories = category

            };

            return View(homeViewModel);
        }

    };

      
}

