using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cotizaciones
    {
        [Key]
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }

        [StringLength(100)]
        public string Comentarios { get; set; }
        public decimal Monto { get; set; }

        public virtual List<CotizacionesDetalles> Detalle { get; set; }

        public Cotizaciones()
        {
            this.Detalle = new List<CotizacionesDetalles>();
        }
       
        public void AgregarDetalle(int id, int cotizacionId, int articuloId, int cantidadCotizada, int precio, int importe)
        {
            this.Detalle.Add(new CotizacionesDetalles(id,cotizacionId,articuloId,cantidadCotizada,precio,importe));
        }
        
    }
}
