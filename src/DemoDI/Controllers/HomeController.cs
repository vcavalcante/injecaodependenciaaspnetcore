using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoDI.Models;

namespace DemoDI.Controllers
{
    public class HomeController : Controller
    {
        
        public IObj1 _obj1 { get; set; }
        public HomeController(IObj1 obj1)
        {
            this._obj1 = obj1;
        }

        public IActionResult Index([FromServices] IObj2 obj2)
        {
            ViewBag.obj1 = this._obj1;
            ViewBag.obj2 = obj2;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        
    }
}
