using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId{ get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int CantidadCotizada { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Precio = 0;
            CantidadCotizada = 0;
        }

        public Articulos(int articuloId, DateTime fecha, string descripcion, decimal costo, decimal precio, int cantidadCotizada)
        {
            ArticuloId = articuloId;
            Fecha = fecha;
            Descripcion = descripcion;
            Costo = costo;
            Precio = precio;
            CantidadCotizada = cantidadCotizada;
        }
    }
}
