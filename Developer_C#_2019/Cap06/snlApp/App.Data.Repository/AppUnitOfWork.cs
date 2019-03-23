using App.Data.DataAccess;
using App.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    // Constructpr: Si no se requiere comportamioento.
    // new crea una instancia de la clase.
    //DB dATAMODEL. Se encuentra las instancia
    // USING. 
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly DbContext _context;

        public IArtistRepository ArtistRepository { get ; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        
        // Ni creao el AppUnitOfWork creo la instancia 
        public AppUnitOfWork()
        {
            _context = new DBDataModel();

            this.ArtistRepository = new ArtistRepository(_context);
            this.CustomerRepository = new CustomerRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
