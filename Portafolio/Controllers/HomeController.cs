﻿using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyecto;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyecto = repositorioProyectos;
        }

        public IActionResult Index()
        {
            
            var proyectos = repositorioProyecto.ObtenerProyectos().Take(3).ToList();    
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
             return View(modelo);
        }
        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyecto.ObtenerProyectos();

            return View(proyectos); 
        }

        [HttpGet]
		public IActionResult Contacto()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
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
