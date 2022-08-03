using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }

    [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
    public virtual Department Department { get; set; }
  }
}