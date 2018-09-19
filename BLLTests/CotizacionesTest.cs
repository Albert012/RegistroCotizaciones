using System;
using System.Collections.Generic;
using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLLTests
{
    [TestClass]
    public class CotizacionesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioCotizaciones repositorio = new RepositorioCotizaciones();
            Assert.IsTrue(repositorio.Guardar(GetCotizacion()));
        }

        private Cotizaciones GetCotizacion()
        {
            return new Cotizaciones
            {
                CotizacionId = 1,
                Fecha = DateTime.Now,
                Comentarios = "Registrando Cotizacion",                
                Detalle = GetCotizacionesDetalles()
            };
        }

        private List<CotizacionesDetalles> GetCotizacionesDetalles()
        {
            return new List<CotizacionesDetalles>
            {
               new CotizacionesDetalles
               {
                   Id = 0,
                   CotizacionId = 1,
                   ArticuloId = 2,
                   CantidadCotizada =2,
                   Precio = 6500,
                   Importe = 13000
               }             

            };
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioCotizaciones repositorio = new RepositorioCotizaciones();
            Assert.IsTrue(repositorio.Modificar(GetCotizacion()));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioCotizaciones repositorio = new RepositorioCotizaciones();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioCotizaciones repositorio = new RepositorioCotizaciones();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Cotizaciones> repositorio = new Repositorio<Cotizaciones>();
            Assert.IsNotNull(repositorio.GetList(c => true));
        }



    }
}
