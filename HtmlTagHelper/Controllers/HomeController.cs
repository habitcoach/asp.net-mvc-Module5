using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HtmlTagHelper.Models;

namespace HtmlTagHelper.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult TagHelperForm()
    {
        // Process form data here (e.g., save to database, send an email)
        // For this example, we'll just return the submitted data as JSON.
        return View();
    }


    [HttpPost]
    public IActionResult TagHelperForm([Bind("Name,Email")] UserModel model)
    {
        // Process form data here (e.g., save to database, send an email)
        // For this example, we'll just return the submitted data as JSON.
        return Ok(model);
    }

    [HttpGet]
    public IActionResult HtmlHelperForm()
    {
        // Process form data here (e.g., save to database, send an email)
        // For this example, we'll just return the submitted data as JSON.
        return View("HtmlHelperForm");
    }


    [HttpPost]
    public IActionResult HtmlHelperForm(UserModel model)
    {
        // Process form data here (e.g., save to database, send an email)
        // For this example, we'll just return the submitted data as JSON.
        return Ok(model);
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

