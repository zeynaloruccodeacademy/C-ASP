using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkASP1.Controllers
{
    public class FeautureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
