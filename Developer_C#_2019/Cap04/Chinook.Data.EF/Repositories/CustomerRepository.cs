using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entities.Base.Repositories
{
    public class CustomerRepository
    {
        private readonly AppDataModel _context;

        public CustomerRepository()
        {
            _context = new AppDataModel();
        }

        public int Count()
        {
            return _context.Artist.Count();
        }

        //public IEnumerable<Customer> GetAll(string nombre)
        //{
        //    return _context.Customer
        //            .Where(item => item.Name.Contains(nombre))
        //            .OrderBy(order => order.Name)
        //            .ThenBy(order => order.ArtistId)
        //            .ToList();
        //}

        public int Insert(Customer entity)
        {
            //Se agrega la informacion al contexto de EF.
            _context.Customer.Add(entity);
            //Confirma la trasaccion
            _context.SaveChanges();

            return entity.CustomerId;
        }

        // Attach se agrega a la memoria temporal
        public bool Update(Customer entity)
        {
            _context.Customer.Attach(entity);
            _context.Entry(entity).State =
                EntityState.Modified;
            var result = _context.SaveChanges();
            return result > 0;
        }

        public bool Delete(Customer entity)
        {
            _context.Customer.Attach(entity);
            _context.Customer.Remove(entity);
            var result = _context.SaveChanges();
            return result > 0;
        }

        public Customer Get(int id)
        {
            return _context.Customer.Find(id);
        }
    }
}
