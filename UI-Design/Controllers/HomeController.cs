using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repo;
using UI_Design.Models;

namespace UI_Design.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Ourmenu()
        {
            List<Food> foodf = new List<Food>();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Food(int food)
        {
            Food foodf = new Food();
            Connection con = new Connection();
            foodf = con.GetUser(food);
            return View(foodf);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
