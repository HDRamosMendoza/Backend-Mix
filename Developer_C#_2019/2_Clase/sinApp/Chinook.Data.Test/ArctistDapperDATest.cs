using System;
/* Linq es para usralo con el count. EDnumerable. */
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chinook.Data;
using Chinook.Entities;

namespace Chinook.Data.Test
{
    [TestClass]
    public class ArctistDapperDATest
    {
        [TestMethod]
        public void GetCount()
        {
            var da = new ArctistDapperDA();
            var cantidad = da.GetCount();
            Assert.IsTrue(cantidad > 0);
        }

        [TestMethod]
        public void GetListado()
        {
            var da = new ArctistDapperDA();
            var listado = da.Gets();
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetsWithParam()
        {
            var da = new ArctistDapperDA();
            var listado = da.GetsWithParam("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void GetsWithParamSP()
        {
            var da = new ArctistDapperDA();
            var listado = da.GetsWithParamSP("a%");
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void InsertArtist()
        {
            var da = new ArctistDapperDA();
            var id = da.InsertArtist( new Artist() {Name="Prueba"});
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void InsertArtistTX()
        {
            var da = new ArctistDapperDA();
            var id = da.InsertArtistTX(new Artist() { Name = "Prueba TX" });
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void InsertArtistTXDist()
        {
            var da = new ArctistDapperDA();
            var id = da.InsertArtistTX(new Artist() { Name = "Prueba InsertArtistTX" });
            Assert.IsTrue(id > 0);
        }

    }
}
