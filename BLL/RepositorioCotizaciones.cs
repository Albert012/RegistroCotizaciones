using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioCotizaciones : Repositorio<Cotizaciones>
    {
        public override bool Guardar(Cotizaciones entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.Cotizaciones.Add(entity) != null)
                {
                    foreach (var item in entity.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticuloId).CantidadCotizada += item.CantidadCotizada;
                    }
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }

            return paso;
        }

        public override bool Modificar(Cotizaciones entity)
        {
            bool paso = false;

            try
            {
                var Ant = contexto.Cotizaciones.Find(entity.CotizacionId);
                foreach (var item in Ant.Detalle)
                {
                    contexto.Articulos.Find(item.ArticuloId).CantidadCotizada -= item.CantidadCotizada;
                    if (!entity.Detalle.Exists(c => c.Id == item.Id))
                    {
                        contexto.Articulos.Find(item.ArticuloId).CantidadCotizada += item.CantidadCotizada;
                        item.Articulo = null;
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                    
                }

                foreach (var item in entity.Detalle)
                {
                    contexto.Articulos.Find(item.ArticuloId).CantidadCotizada += item.CantidadCotizada;
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                contexto.Entry(entity).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                    paso = true;

            }
            catch(Exception)
            {
                throw;
            }

            return paso;
        }

        public override bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                Cotizaciones cotizaciones = contexto.Cotizaciones.Find(id);

                foreach (var item in cotizaciones.Detalle)
                {
                    contexto.Articulos.Find(item.ArticuloId).CantidadCotizada -= item.CantidadCotizada;
                }
                
                contexto.Cotizaciones.Remove(cotizaciones);
                contexto.SaveChanges();
                paso = true;

            }
            catch(Exception)
            {
                throw;
            }
            return paso; 
        }

        public override Cotizaciones Buscar(int id)
        {
            Cotizaciones cotizaciones = new Cotizaciones();

            try
            {
                cotizaciones = contexto.Cotizaciones.Find(id);

                foreach (var item in cotizaciones.Detalle)
                {
                    string a = item.Articulo.Descripcion;
                }
            }
            catch(Exception)
            {
                throw;
            }

            return cotizaciones;
        }


    }
}
