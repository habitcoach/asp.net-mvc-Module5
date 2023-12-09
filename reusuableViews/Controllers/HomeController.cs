using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using reusuableViews.Models;

namespace reusuableViews.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<string> comments = new List<string>
        {
            "comment01","comment02"
            // Add more comments here as needed
        };

        return View(comments);
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

