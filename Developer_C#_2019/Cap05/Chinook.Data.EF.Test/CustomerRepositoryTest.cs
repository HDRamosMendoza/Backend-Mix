using System;
using Chinook.Data.EF.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.EF.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void UpdateAddress()
        {
            var rep = new CustomerRepository();
            rep.UpdateAddress();


        }
    }
}
