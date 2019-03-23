using System;
using System.Collections.Generic;
using App.Data.DataAccess;
using App.Data.Repository.Interface;
using App.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.Repository.Test
{
    [TestClass]
    public class ArtistRepositoryTest
    {
        [TestMethod]
        public void Count()
        {
            var _context = new DBDataModel();
            IArtistRepository rep = new ArtistRepository(_context);
            var count = rep.Count();

            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void CountUW()
        {
            var count = 0;
            using (var unitOfWork = new AppUnitOfWork())
            {
                // Manejar el conecto de transaccionalidad.
                // NO s aseguramos que los recursos se han liberado.
                count = unitOfWork.ArtistRepository.Count();
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void Insert()
        {
            int result = 0;
            using (var unitOfWork = new AppUnitOfWork())
            {
                var entity = new Artist();
                entity.Name = "Artist-" + Guid.NewGuid();
                unitOfWork.ArtistRepository.Add(entity);
                result = unitOfWork.Complete();
            }
            Assert.IsTrue(result>0);
        }

        //[TestMethod]
        //public void Insert()
        //{
        //    bool result = false;
        //    using (var unitOfWork = new AppUnitOfWork())
        //    {
        //        var entity = new Artist();
        //        // Aleatorio Guid.NewGuid()
        //        entity.Name = "Artist-" + Guid.NewGuid();
        //        result = unitOfWork.ArtistRepository.Add(entity);
        //        unitOfWork.Complete();
        //    }
        //    Assert.IsTrue(result);
        //}

        [TestMethod]
        public void Update()
        {
            int result = 0;
            using (var unitOfWork = new AppUnitOfWork())
            {
                var entity = new Artist();
                entity.ArtistId = 289;
                entity.Name = "Artist-" + Guid.NewGuid();
                unitOfWork.ArtistRepository.Add(entity);
                result = unitOfWork.Complete();
            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Delete()
        {
            int result = 0;
            using (var unitOfWork = new AppUnitOfWork())
            {
                var entity = new Artist();
                entity.ArtistId = 289;
                unitOfWork.ArtistRepository.Remove(entity);
                result = unitOfWork.Complete();
            }
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Get()
        {
            Artist result = null;
            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.ArtistRepository.GetById<int>(1);
                // No es necesario usar el COMPLETE
                //unitOfWork.Complete();
            }
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAll()
        {
            List<Artist> result = null;
            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.ArtistRepository.GetAll();
                // No es necesario usar el COMPLETE
                //unitOfWork.Complete();
            }
            Assert.IsNotNull(result);
        }

    }
}