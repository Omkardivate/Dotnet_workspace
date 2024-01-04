using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using BOL;
using BLL;

namespace MVCApp.Controllers;

public class StudentsController : Controller
{
    private readonly ILogger<StudentsController> _logger;

    public StudentsController(ILogger<StudentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        StudentManager ob=new StudentManager();
        List<Student> slist= ob.GetAllStudents();
        
        return View(slist);
    }

    
}
