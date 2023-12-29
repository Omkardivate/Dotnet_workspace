using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcproject.Models;

namespace mvcproject.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string companyName,string contactName)
    {
        Console.WriteLine("Company data: "+companyName+" "+contactName);
        return RedirectToAction("Login")    ;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username,string password)
    {
        Console.WriteLine("User data: "+ username +" "+ password);
        if(username=="omkar" && password=="om"){
            return RedirectToAction("Welcome");
        }
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
