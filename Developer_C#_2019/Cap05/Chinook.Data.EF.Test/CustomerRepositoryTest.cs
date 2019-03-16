using System;
using Chinook.Data.EF.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.EF.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        // Me aseuro que actualizo todo
        [TestMethod]
        public void Update()
        {
            var rep = new CustomerRepository();
            var entity = rep.Get(1);
            entity.FirstName = "Jose Manuel";
            rep.Update(entity);

            var entityActualizada = rep.Get(1);
            var result = entityActualizada.FirstName == "Jose Manue";

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateAddress()
        {
            var rep = new CustomerRepository();
            rep.UpdateAddress(
                new Customer() {
                        
                }
            );


        }
    }
}
