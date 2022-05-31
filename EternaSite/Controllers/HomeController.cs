using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EternaSite.Models;

namespace EternaSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> services = new List<Service>
            {
                new Service
                {
                    Id = 1,
                    Icon = "bx bxl-dribbble",
                    Title = "Lorem Ipsum",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 2,
                    Icon = "bx bx-file",
                    Title = "Dolor Sitema",
                    Content = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },
                new Service
                {
                    Id = 3,
                    Icon = "bx bx-tachometer",
                    Title = "Sed ut perspiciatis",
                    Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                },
                new Service
                {
                    Id = 4,
                    Icon = "bx bx-world",
                    Title = "Nemo Enim",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 5,
                    Icon = "bx bx-slideshow",
                    Title = "Dele cardo",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 6,
                    Icon = "bx bx-arch",
                    Title = "Divera don",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
            };

            return View(services);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            List<Service> services = new List<Service>
            {
                new Service
                {
                    Id = 1,
                    Icon = "bx bxl-dribbble",
                    Title = "Lorem Ipsum",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 2,
                    Icon = "bx bx-file",
                    Title = "Dolor Sitema",
                    Content = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },
                new Service
                {
                    Id = 3,
                    Icon = "bx bx-tachometer",
                    Title = "Sed ut perspiciatis",
                    Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                },
                new Service
                {
                    Id = 4,
                    Icon = "bx bx-world",
                    Title = "Nemo Enim",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 5,
                    Icon = "bx bx-slideshow",
                    Title = "Dele cardo",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 6,
                    Icon = "bx bx-arch",
                    Title = "Divera don",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
            };
            return View(services);
        }

        public IActionResult ServiceDetail(int id)
        {
            List<Service> services = new List<Service>
            {
                new Service
                {
                    Id = 1,
                    Icon = "bx bxl-dribbble",
                    Title = "Lorem Ipsum",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 2,
                    Icon = "bx bx-file",
                    Title = "Dolor Sitema",
                    Content = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },
                new Service
                {
                    Id = 3,
                    Icon = "bx bx-tachometer",
                    Title = "Sed ut perspiciatis",
                    Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                },
                new Service
                {
                    Id = 4,
                    Icon = "bx bx-world",
                    Title = "Nemo Enim",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 5,
                    Icon = "bx bx-slideshow",
                    Title = "Dele cardo",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Service
                {
                    Id = 6,
                    Icon = "bx bx-arch",
                    Title = "Divera don",
                    Content = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
            };

            Service service = services.Find(x=>x.Id == id);
            return View(service);
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }
    }
}
