using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){FirstName = "Ahmet", LastName= "Kısa"},
            new Student(){FirstName = "Selim", LastName= "Akca"},
            new Student(){FirstName = "Furkan", LastName= "Say"},
            new Student(){FirstName = "Tolga", LastName= "Keskin"},
            new Student(){FirstName = "İbrahim", LastName= "Yılmaz"}
        };
        public IActionResult GetStudentList()
        {
            return View(students);
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return View("GetStudentList",students);
        }
    }
}
