using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProductos
{
    public class ListaProductos
    {
        public List<Producto> Productos { set; get; }
        public ListaProductos()
        {
            Productos = new List<Producto>();
        }
        public void AnadirElemento(Producto producto)
        {
            Productos.Add(producto);
        }
        public List<Producto> NombreLetra(string Letra)
        {
            List<Producto> aux = new List<Producto>();
            foreach(Producto producto in Productos)
            {
                if(producto.Nombre.Contains(Letra))
                {
                    aux.Add(producto);
                }
            }
            return aux;
        }
        

    }
}
