using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var a = new AlumnoModel();
            a.Nombre = "Hector Omar";
            a.App = "Nava";
            a.Apm = "Gonzalez";
            a.Carrera = "Informática";
            a.FechaIngreso = DateTime.Now;
            a.NC = "17030098";
            a.Promedio = 9.19;

            return View(a);
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
