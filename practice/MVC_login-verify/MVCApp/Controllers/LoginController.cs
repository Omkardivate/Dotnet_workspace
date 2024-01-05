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
        StudentManager ob=new StudentManager();
        List<Credentials> slist= ob.GetCredentials();

        foreach (Credentials c in slist)
        {
            if(username== c.UserName && password== c.Password ){
                return RedirectToAction("Index","Students");
            }
        }
        
        return View();
    }
    
}
