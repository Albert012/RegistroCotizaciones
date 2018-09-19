using System;
using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLLTests
{
    [TestClass]
    public class ArticulosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>();            
            Assert.IsTrue(repositorio.Guardar(GetArticulos()));
        }

        private Articulos GetArticulos()
        {
            return new Articulos
            {
                ArticuloId = 2,
                Fecha = DateTime.Now,//.AddDays(3),
                Descripcion = "Hp Pavilon",
                Costo = 7500,
                Precio = 8500,
                CantidadCotizada = 0
            };
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>();
            Assert.IsTrue(repositorio.Modificar(GetArticulos()));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>();
            Assert.IsNotNull(repositorio.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>();
            Assert.IsNotNull(repositorio.GetList(a => true));
        }
    }
}
