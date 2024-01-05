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
    
    [HttpGet]
    public IActionResult Edit()
    {   
        StudentManager ob=new StudentManager();
        List<Student> slist= ob.GetAllStudents();
        return View(slist);
    }

    [HttpPost]
    public IActionResult Edit(int id,string fn,string ln,string email)
    {   
        StudentManager ob=new StudentManager();
        bool flag= ob.Edit(id,fn,ln,email);
        if(flag){
            return this.RedirectToAction("Index");
        }
        return View();
    }

    
}
