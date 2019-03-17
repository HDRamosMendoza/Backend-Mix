using System;
using App.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArtistRepositoryTest
{
    [TestClass]
    public class ArtistRepositoryTest
    {
        [TestMethod]
        public void Count()
        {
            var _context = new DBDataModel();
            ArtistRepository rep = new ArtistRepositoryTest(_context);
            var count = rep.Count();

            Assert.IsTrue(count > 0);
        }
    }
}
