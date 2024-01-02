using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using BLL;
using BOL;
namespace MVCApp.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private UserManager ob= new UserManager();

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<User> ulist=ob.GetUsers();
        ViewData["users"]= ulist;
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]   
    public IActionResult Login(string username,string password)
    {
        List<User> ulist=ob.GetUsers();
        foreach(User u in ulist){
            if(u.Name==username && u.Pwd==password){
                return this.RedirectToAction("Welcome");
            }
        }
        Console.WriteLine("Wrong credentials !!!");
        return View();
    }

    [HttpGet]
    public IActionResult Registration()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Welcome()
    {
        return View();
    }

}
