using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana_16.Controllers
{
    public class AyudaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ayuda(string name, int numTimes = 1)
        {

            ViewData["name"] = "Hola " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}