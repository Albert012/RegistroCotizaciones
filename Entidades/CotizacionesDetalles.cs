using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CotizacionesDetalles
    {
        [Key]

        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int ArticuloId { get; set; }
        public int CantidadCotizada { get; set; }
        public Decimal Precio { get; set; }
        public Decimal Importe { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulo { get; set; }

        public CotizacionesDetalles()
        {
            Id = 0;
            CotizacionId = 0;
            ArticuloId = 0;
            CantidadCotizada = 0;
            Precio = 0;
            Importe = 0;
          
        }

        public CotizacionesDetalles(int id, int cotizacionId, int articuloId, int cantidadCotizada, decimal precio, decimal importe)
        {
            Id = id;
            CotizacionId = cotizacionId;
            ArticuloId = articuloId;
            CantidadCotizada = cantidadCotizada;
            Precio = precio;
            Importe = importe;
        }
    }
}
