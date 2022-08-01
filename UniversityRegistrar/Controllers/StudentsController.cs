using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniversityRegistrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public StudentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Students";
      return View(_db.Students.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "New Student";
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student, int CourseId)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
        if (CourseId != 0)
        {
          _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
          _db.SaveChanges();
        }
        return RedirectToAction("Index");
     }

    public ActionResult AddCourse(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      ViewBag.PageTile = "Add Course";
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult AddCourse(Student student, int CourseId )
    {
      if (CourseId != 0)
      {
        _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}