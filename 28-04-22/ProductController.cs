using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWorkCore2.Models;

namespace EntityFrameWorkCore2.Controllers
{
    public class ProductController : Controller
    {
        [Route("Product1/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Index/Create")]
        public IActionResult Create(Product1 p)
        {
            
            if (ModelState.IsValid)
            {
                Product1DBC PT = new Product1DBC();
                PT.Add(p);
                PT.SaveChanges();
                return Content("Saved");
            }
            return View("Index");

        }
    }
}
