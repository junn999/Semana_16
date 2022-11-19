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
        public IActionResult Ayuda(string name, string question, int numTimes = 1)
        {

            ViewData["name"] = "Hola " + name + " " + question;
            ViewData["numTimes"] = numTimes;
            ViewData["question"] = question;
            return View();
        }
    }
}