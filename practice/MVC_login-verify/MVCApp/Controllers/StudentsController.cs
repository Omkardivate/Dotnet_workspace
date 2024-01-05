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
    public IActionResult Edit(int id)
    {   
        StudentManager ob=new StudentManager();
        Student s= ob.GetStudent(id);
        
        ViewData["student"]= s;
        return View();
    }

    [HttpPost]
    public IActionResult Edit(int id,string fname,string lname,string email)
    {   
        Console.WriteLine("Updation in process...."+fname+" "+lname);
        StudentManager ob=new StudentManager();
        bool status= ob.Update(id,fname,lname,email);
       
        if(status){
            return this.RedirectToAction("Index");
        }
        
        return View();
    }

    
    [HttpGet]
    public IActionResult Delete(int id)
    {   
        StudentManager ob=new StudentManager();
        bool status= ob.DeleteStudent(id);
        
        if(status){
            return this.RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    
    [HttpPost]
    public IActionResult Insert(int id,string fname,string lname,string date,string email)
    {
        StudentManager ob=new StudentManager();
        bool status= ob.Insert(id,fname,lname,date,email);
        
        if(status){
            return this.RedirectToAction("Index");
        }
        return View();
    }


}
