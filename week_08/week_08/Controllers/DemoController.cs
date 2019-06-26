using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week_08.Models;

namespace week_08.Controllers
{
    public class DemoController : Controller
    { 
       
        
        // GET: Demo
        public ActionResult Customer()
        {
            return View();
        }
    }
}
