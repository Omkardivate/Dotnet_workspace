using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;
namespace MVCApp.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string username,string password)
    {
        if(username=="user" && password=="user123"){
            return RedirectToAction("Index","Students");
        }
        return View();
    }

    public IActionResult Students()
    {
        StudentManager ob=new StudentManager();
        List<Student> slist= ob.GetAllStudents();
        
        return View(slist);
    }

    
}
