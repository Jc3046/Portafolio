using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
             return View(modelo);
        }

        private List<ProyectoDIO> ObtenerProyectos()
        {
            return new List<ProyectoDIO>() { 
                new ProyectoDIO
            {
                Titulo="Amazon",
                Descripcion="E-Commerce realziado en ASP.NET Core",
                Link="https://amazon.com",
                ImagenURL="/imagenes/amazon.png"
            },

             new ProyectoDIO
            {
                Titulo="New York Times",
                Descripcion="Pagina de noticias en React",
                Link="https://nytimes.com",
                ImagenURL="/imagenes/NYT.png"
            },

              new ProyectoDIO
            {
                Titulo="Redit",
                Descripcion="Red social para compartir en comunidades",
                Link="https://reddit.com",
                ImagenURL="/imagenes/reddit.png"
            },

             new ProyectoDIO
            {
                Titulo="Steam",
                Descripcion="Tienda en linea para comprar videojuegos",
                Link="https://store.steampowered.com",
                ImagenURL="/imagenes/steam.png"
            },
            };
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
