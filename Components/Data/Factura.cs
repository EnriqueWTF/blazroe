using System.Collections.Generic;
using System.Linq;

namespace blazroe.Components.Data 
{
    public class Factura
    {
        public int Identificador { get; set; }

       
        public string NombreCliente { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

       
        public List<Articulo> Articulos { get; set; } = new List<Articulo>();

        public decimal Total => Articulos.Sum(articulo => articulo.Precio);
    }
}   