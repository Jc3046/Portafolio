using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<ProyectoDIO> ObtenerProyectos()
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
    }
}
