using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentaAutomoviles.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Acerca()
        {
            return View();
        }

        public IActionResult Contactenos()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult Iniciosesion()
        {
            return View();
        }
    }
}
