using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProductos
{
    public class Producto
    {
        public string Nombre { set; get; }
        public string Tamanio { set; get; }
        public string Color { set; get; }
        public string Estado { set; get; }

        public Producto()
        {
        }

        public Producto(string nombre, string tamanio, string color, string estado)
        {
            Nombre = nombre;
            Tamanio = tamanio;
            Color = color;
            Estado = estado;
        }
    }
}
