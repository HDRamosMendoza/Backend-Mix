using System;
using System.Linq;
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
    }
}
