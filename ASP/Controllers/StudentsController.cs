using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.Models;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentData studentData;

        public StudentsController()
        {
            this.studentData = new StudentData();
        }


        // GET: Students
        public ActionResult Index()
        {
            List<Student> students = this.studentData.GetStudents();
            return View(students);
        }

        public ActionResult ById()
        {
            return View();
        }

        [HttpGet]
        public  ActionResult ById(string id)
        {
            var student = this.studentData.GetStudent(Convert.ToInt32(id));
            return View(student);
        }
    }
}