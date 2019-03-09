using System;
using System.Linq;
using Chinook.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.Test
{
    [TestClass]
    public class AlbumDapperDATest
    {
        [TestMethod]
        public void GetCount()
        {
            var da = new AlbumDapperDA();
            var cantidad = da.GetCount();
            Assert.IsTrue(cantidad > 0);
        }

        [TestMethod]
        public void GetListado()
        {
            var da = new AlbumDapperDA();
            var listado = da.Gets();
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetsWithParam()
        {
            var da = new AlbumDapperDA();
            var listado = da.GetsWithParam("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetsWithParamSP()
        {
            var da = new AlbumDapperDA();
            var listado = da.GetsWithParamSP("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void InsertAlbum()
        {
            var da = new AlbumDapperDA();
            var id = da.InsertAlbum(
                new Album() {
                    Title = "Prueba Album",
                    ArtistId = 1
                }
            );
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void UpdateAlbumTXDist()
        {
            var da = new AlbumDapperDA();
            var resultado = da.UpdateAlbumTXDist(
                new Album() {
                    Title = "Prueba TX",
                    AlbumId = 1
                }
            );
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeleteAlbumTXDist()
        {
            var da = new AlbumDapperDA();
            var resultado = da.DeleteAlbumTXDist(2);
            Assert.IsTrue(resultado);
        }

    }
}
