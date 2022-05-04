
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdoMVC.DAL;
using AdoMVC.Models;

namespace AdoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("Home/Index1")]
        public IActionResult Index1()
        {
            CustomerDAL custDAL = new CustomerDAL();
            List<Customer> CustomerList = new List<Customer>();
            CustomerList = custDAL.GetAllCustomers();
            return View(CustomerList);
        }
        [Route("Home/Insert")]
        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult InsertRow(Customer c)
        {
            int result;
            int CustomerID = c.CustomerID;
            string CustomerName = c.CustomerName;
            string EmailID = c.EmailID;
            string MobileNo = c.MobileNo;
            CustomerDAL cobj = new CustomerDAL();
           result= cobj.Insert(CustomerID,CustomerName,EmailID,MobileNo);
            if (result == 1)
            {
                return RedirectToAction("Index1");
            }
            else return RedirectToAction("Insert");
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

