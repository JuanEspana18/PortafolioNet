using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }


    public class RepositorioProyectos: IRepositorioProyectos
    {
       
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                    Titulo = "Amazon",
                    Descripcion = "Tienda Online de variedades",
                    Link = "https://amazon.com",
                    ImagenURL = "/imgs/amazon.jpg"
            },
                new Proyecto
            {
                    Titulo = "Steam",
                    Descripcion = "Tienda Online de juegos",
                    Link = "https://store.steampowered.com/",
                    ImagenURL = "/imgs/steam.jpg"
            },
                new Proyecto
            {
                    Titulo = "FlashScore",
                    Descripcion = "Resultados de deportes en línea",
                    Link = "https://www.flashscore.co/",
                    ImagenURL = "/imgs/ff.png"
            },
                new Proyecto
            {
                    Titulo = "Temu",
                    Descripcion = "Tienda Online de compras de diferentes objetos",
                    Link = "https://www.temu.com/",
                    ImagenURL = "/imgs/temu.jpg"
            }
            };
        }
    }
}
