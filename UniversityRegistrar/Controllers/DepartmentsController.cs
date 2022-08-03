using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;
    
    public DepartmentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }
    
    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Departments";
      List<Department> model = _db.Departments.ToList();
      return View(model);
    }
    
    public ActionResult Create()
    {
     ViewBag.PageTitle = "New Department";
     return View(); 
    }
    
    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}