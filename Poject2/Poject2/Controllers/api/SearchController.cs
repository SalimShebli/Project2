using Poject2.Models;
using Poject2.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poject2.Controllers.api
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        ApplicationDbContext _context;

        public SearchController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
#region Get for doctors and students
        [HttpGet]
        public ActionResult GetDoctorOrStudentByName(string doctorName, string userId,bool justStudents,bool justDoctors)
        {
            if (!ModelState.IsValid)
            {
                //TODO
            }
            var Doctors = new List<Doctor>();
            var Students = new List<Student>();
           if(justDoctors)
           {
               Doctors = _context.Doctor.Where(m => (m.person.fName + " " + m.person.lName).Contains(doctorName)).ToList();
           }
           else if(justStudents)
           {
               Students = _context.Student.Where(m => (m.person.fName + " " + m.person.lName).Contains(doctorName)).ToList();
           }
           else
           {
               Doctors = _context.Doctor.Where(m => (m.person.fName + " " + m.person.lName).Contains(doctorName)).ToList();
               Students = _context.Student.Where(m => (m.person.fName + " " + m.person.lName).Contains(doctorName)).ToList();
           }
           
           ViewBag.Students = Students;
           ViewBag.Doctors = Doctors;
            return View();
        }
         [HttpGet]
        public ActionResult GetStudentBySubjects(List<Subject> subjects,string userId)
        {
            if (!ModelState.IsValid)
            {
                //TODO
            }
            var Students = new List<Student>();
            for (int i = 0; i < subjects.Count;i++ )
               Students.AddRange(_context.Student.Where(m => m.ListSubject.Contains(subjects[i]) && 
                   !Students.Contains(m)).ToList());
            ViewBag.Students = Students;
            return View();
        }

    }
#endregion
}