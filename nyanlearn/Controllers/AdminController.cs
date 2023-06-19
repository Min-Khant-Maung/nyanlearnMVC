using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nyanlearn.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


                public IActionResult ListStudents()
        {
            return View("~/Views/Admin/StudentList.cshtml");
        }

        public IActionResult AddStudent()
        {
            return View("~/Views/Admin/StudentRegForm.cshtml");
        }

        public IActionResult ListTeachers()
        {
            return View("~/Views/Admin/TeacherList.cshtml");
        }



        public IActionResult AddTeacher()
        {
            return View("~/Views/Admin/TeacherRegForm.cshtml");
        }
    }
}
