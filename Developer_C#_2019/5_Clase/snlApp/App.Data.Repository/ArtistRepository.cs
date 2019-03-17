using App.Data.Repository.Interface;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class ArtistRepository: IArtistRepository
    {
        protected readonly DbContext _context;

        public ArtistRepository(DbContext context)
        {
            _context = context;
        }

       

        public bool Add(Artist entity) {
            _context.Set<Artist>().Add(entity);
            // Confirmando los cambios
            return true;
        }

        public int Count() {
            return _context.Set<Artist>().Count();
        }

        public List<Artist> GetAll() {
            //throw new NotImplementedException();
            return _context.Set<Artist>().ToList();
        }

        public Artist GetById(int id) {
            throw new NotImplementedException();
        }

        public bool Remove(Artist entity) {
            _context.Set<Artist>().Attach(entity);
            _context.Set<Artist>().Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Artist entity)
        {
            throw new NotImplementedException();
        }
    }
}
