using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArticulosRegistro.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArticulosRegistro.Entidades;
using ArticulosRegistro.DAL;

namespace ArticulosRegistro.BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulo articulo = new Articulo();
            articulo.ArticuloId = 1;
            articulo.FechaVencimiento = DateTime.Now;
            articulo.Descripcion = "Arroz";
            articulo.Precio = 100f;
            articulo.Existencia = 20f;
            articulo.CantCotizada = 10f;
            paso = ArticuloBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulo articulo = new Articulo();
            articulo.CantCotizada = 20f;
            paso = ArticuloBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest(int id)
        {
            bool paso;
            Contexto contexto = new Contexto();
            Articulo articulo = contexto.Articulo.Find(id);
            contexto.Articulo.Remove(articulo);
            paso = ArticuloBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest(int id)
        {
            bool paso;
            Contexto contexto = new Contexto();
            Articulo articulo = new Articulo();
            articulo = contexto.Articulo.Find(id);
            //paso = ArticuloBLL.Buscar(id);
           // Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}