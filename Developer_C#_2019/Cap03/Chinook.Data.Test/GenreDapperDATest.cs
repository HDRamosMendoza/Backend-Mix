using System;
using System.Linq;
using Chinook.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.Test
{
    [TestClass]
    public class GenreDapperDATest
    {
        [TestMethod]
        public void GetCount()
        {
            var da = new GenreDapperDA();
            var cantidad = da.GetCount();
            Assert.IsTrue(cantidad > 0);
        }

        [TestMethod]
        public void GetListado()
        {
            var da = new GenreDapperDA();
            var listado = da.Gets();
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetsWithParam()
        {
            var da = new GenreDapperDA();
            var listado = da.GetsWithParam("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetsWithParamSP()
        {
            var da = new GenreDapperDA();
            var listado = da.GetsWithParamSP("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void InsertGenre()
        {
            var da = new GenreDapperDA();
            var id = da.InsertGenre(
                new Genre() {
                    Name = "Prueba Genre"
                }
            );
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void UpdateGenreTXDist()
        {
            var da = new GenreDapperDA();
            var resultado = da.UpdateGenreTXDist(
                new Genre() {
                    Name = "Prueba TX",
                    GenreId = 1
                }
            );
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeleteGenreTXDist()
        {
            var da = new GenreDapperDA();
            var resultado = da.DeleteGenreTXDist(2);
            Assert.IsTrue(resultado);
        }
    }
}
