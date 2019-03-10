using System;
using System.Linq;
using Chinook.Entities.Base;
using Chinook.Entities.Base.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.EF.Test
{
    [TestClass]
    public class ArtistRepositoryTest
    {
        [TestMethod]
        public void Count()
        {
            var repository = new ArtistRepository();
            var count = repository.Count();
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void GetAll()
        {
            var repository = new ArtistRepository();
            var listado = repository.GetAll("");
            /* Si no reconoce el Count es por que no usan el using Syhstem.Linq*/
            Assert.IsTrue(listado.Count()>0);
        }
        
        [TestMethod]
        public void GetAllWithFilter()
        {
            var repository = new ArtistRepository();
            var listado = repository.GetAll("aer");

            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void Insert()
        {
            var repository = new ArtistRepository();
            var artist = new Artist();
            artist.Name = "Pedro Diaz";
            var id = repository.Insert(artist);

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void Delete()
        {
            var repository = new ArtistRepository();
            var artist = new Artist();
            artist.ArtistId = 288;
            var isSuccess = repository.Delete(artist);

            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Get()
        {
            var repository = new ArtistRepository();
            var entity = repository.Get(1);
            Assert.IsNotNull(entity);
        }
    }
}
