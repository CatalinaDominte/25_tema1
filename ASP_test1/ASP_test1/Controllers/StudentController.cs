using ASP_test1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_test1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        readonly List<Student> studentList = new List<Student>() { };
        public ActionResult Index()
        {
            studentList.Add(new Student { StudentId = 1, StudentName = "John", Age = 18 });
            studentList.Add(new Student { StudentId = 2, StudentName = "Steve", Age = 21 });
            studentList.Add(new Student { StudentId = 3, StudentName = "Bill", Age = 25 });
            studentList.Add(new Student { StudentId = 4, StudentName = "Ram", Age = 20 });
            studentList.Add(new Student { StudentId = 5, StudentName = "Ron", Age = 31 });
            studentList.Add(new Student { StudentId = 4, StudentName = "Chris", Age = 17 });
            studentList.Add(new Student { StudentId = 4, StudentName = "Rob", Age = 19 });


            return View(studentList);
            
        }
        
        public Student GetStudent(int id)
        {
           
            return studentList.Where(s => s.StudentId == id).FirstOrDefault();
        }

    }
}