using Project2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project2.DAL;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/Validate")]
        public IActionResult Validate(User usr)
        {
            if (ModelState.IsValid)
            {
                ProjectDAL pobj = new ProjectDAL();
                int result = pobj.Usercheck(usr);
                if (result == 1)
                {
                    return View("Homepage");
                }
                else
                {
                    return View("Content");
                }

            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult HomePage()
        {
            return View();
        }
        [Route("Home/InsertP")]
        public IActionResult PatientAdd1()
        {
            return View();
        }
        public IActionResult InsertPatient(AddPatient p)
        {
            int result;
            string FirstName = p.Fname;
            string LastName = p.Lname;
            string Sex = p.Gender;
            string Dateof = p.DoB;
            ProjectDAL cobj = new ProjectDAL();
            result = cobj.Patient1( FirstName, LastName, Sex, Dateof);
            if (result == 1)
            {
                
                return View("PatientContent");
            }
            else return RedirectToAction("Homepage");
        }

        public IActionResult DoctorAdd1()
        {
            return View();
        }

        public IActionResult InsertD(AddDoctor d)
        {
            int result;
            string FName = d.FirstName;
            string LName = d.LastName;
            string gen = d.Sex;
            string special = d.Specialization;
            string visith = d.VistingHours;
            ProjectDAL cobj = new ProjectDAL();
            result = cobj.DoctorAdd1(FName, LName, gen, special, visith);
            if (result == 1)
            {
                
                return View("DoctorContent");
            }
            else return RedirectToAction("InsertD");
        }

        public IActionResult ScheduleA()
        {
            return View();
        }
        public IActionResult Appointment(Appoint A)
        {
            int result;
            ProjectDAL cobj = new ProjectDAL();
            result = cobj.AppointN(A);
            if (result == 1)
            {
                
                return View("AppointContent");
            }
            else return RedirectToAction("Appointment");
        }
        //public IActionResult DisplayAppoin()
        //{
        //    return View();
        //}
        public IActionResult DisplayAppoin()
        {
            ProjectDAL SDAL = new ProjectDAL();
            List<Appoint> App = new List<Appoint>();
            App = SDAL.Schlist();
            return View(App);
        }


        public IActionResult CancelA(int id)
        {
            ProjectDAL obj = new ProjectDAL();
            int result = obj.Cancel(id);
            if (result == 1)
            {
                
                return View("CancelContent");
            }
            else
                return View("Homepage");


        }

        //public IActionResult Usercreate()
        //{
        //    return View();
        //}
        //public IActionResult Creation(User au)
        //{
        //    ProjectDAL obj = new ProjectDAL();
        //    int result = obj.Creator(au);
        //    if (result == 1)
        //        return RedirectToAction("Homepage");
        //    else
        //        return View("Content1");

        //}
        [Route("Displaydoctor")]
        public IActionResult DisplayDoctorList()
        {
            List<AddDoctor> listSchedules = new List<AddDoctor>();
            ProjectDAL dobj = new ProjectDAL();
            listSchedules = dobj.Displaydoc();
            return View(listSchedules);
            
        }
        public IActionResult DisplayPatientList()
        {
            List<AddPatient> listSchedules = new List<AddPatient>();
            ProjectDAL dobj = new ProjectDAL();
            listSchedules = dobj.Displaypatient();
            return View(listSchedules);

        }

        public IActionResult Privacy()
        {
            return View();
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
