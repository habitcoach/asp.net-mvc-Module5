using HtmlHelper_Adventure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace HtmlHelper_Adventure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var touristPlaces = new List<string>
        {
            "Mountain Trek",
            "Beach Vacation",
            "Jungle Safari",
            "City Exploration"
        };

            ViewBag.TouristPlaces = new SelectList(touristPlaces);
            return View();
        }

        public IActionResult TagView()
        {
            var touristPlaces = new List<string>
        {
            "Mountain Trek",
            "Beach Vacation",
            "Jungle Safari",
            "City Exploration"
        };

            ViewBag.TouristPlaces = new SelectList(touristPlaces);
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(string selectedPlace)
        {
            // Handle the form submission logic here
            ViewBag.SelectedPlace = selectedPlace;
            return Content($"You have selected: {@ViewBag.SelectedPlace}");
        }

        [HttpPost]
        public IActionResult SubmitForm4Tag(IFormCollection form)
        {
            // Handle the form submission logic here
            string selectedValue = form["selectedPlace"];
            return Content($"You have selected: {selectedValue}");
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