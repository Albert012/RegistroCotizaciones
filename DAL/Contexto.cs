using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Cotizaciones> Cotizaciones { get; set; }
        //public DbSet<T> Entity { get; set; }

        public Contexto():base("ConStr")
        {

        }
    }
}
