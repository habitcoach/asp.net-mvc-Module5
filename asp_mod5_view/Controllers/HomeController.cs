using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp_mod5_view.Models;

namespace asp_mod5_view.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<string> names = new List<string>() { "name01", "Name02", "Name03" };

        ViewBag.Name = names;

        ViewData["Message"] = "this is from view data";

        

       

        

        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Test()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

