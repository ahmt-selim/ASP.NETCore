﻿using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class TeacherController : Controller
    {
        List<Branch> branches = new List<Branch>()
        {
            new Branch(){ID = 1, BranchName="Matematik"},
            new Branch(){ID = 2, BranchName="Edebiyat"},
            new Branch(){ID = 3, BranchName="Fizik"}
        };
        public IActionResult AddTeacher()
        {
            ViewBag.Branches = branches;
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        }
    }
}
