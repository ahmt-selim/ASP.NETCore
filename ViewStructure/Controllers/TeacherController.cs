using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){ID=1, Name="Ahmet",Gender="man"},
            new Teacher(){ID=2, Name="Selim",Gender="man"},
            new Teacher(){ID=3, Name="Ayşe",Gender="woman"},
            new Teacher(){ID=4, Name="Merve",Gender="woman"},
        };
        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }
        public IActionResult DeleteTeacher(int id)
        {
            return View();
        }
    }
}
