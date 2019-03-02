using System;
/* Linq es para usralo con el count. EDnumerable. */
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chinook.Data;
using Chinook.Entities;

namespace Chinook.Data.Test
{
    [TestClass]
    public class GenreDATest
    {
        [TestMethod]
        public void GetCount()
        {
            var da = new GenreDA();
            var cantidad = da.GetCount();
            Assert.IsTrue(cantidad > 0);
        }

        [TestMethod]
        public void UpdateGenre()
        {
            var da = new GenreDA();
                
            var id = da.UpdateGenre(new Genre() {GenreId=3,Name="Prueba de Update 2"});
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void DeleteGenre()
        {
            var da = new GenreDA();

            var id = da.DeleteGenre(new Genre()
            {
                GenreId = 6
            });
            Assert.IsTrue(id > 0);
        }

    }
}
