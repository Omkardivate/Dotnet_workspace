using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BOL;  // for 'Person' objects
using BLL;  // for accessing methods

namespace Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // List<Person> plist = new List<Person>();
        // Person obj1 = new Person("Adi", 23069, "IET");
        // Person obj2 = new Person("Omi", 72069, "Iet");
        // plist.Add(obj1);
        // plist.Add(obj2);

        PersonBLL obj = new PersonBLL();
        List<Person> plist = obj.GetAllStudents();

        ViewData["students"] = plist;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


}
