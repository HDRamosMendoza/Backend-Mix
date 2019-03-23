using App.Data.Repository.Interface;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class GenericRepository<TEntity>:IGenericRepository<TEntity>
        where TEntity:class
    {
        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public bool Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            //En el unitOfWork ya lo tiene implementado.
            //_context.SaveChanges();
            return true;
        }

        //public bool Add(TEntity entity)
        //{
        //    _context.Set<TEntity>().Add(entity);
        //    //Confirmando los cambios
        //    _context.SaveChanges();
        //    return true;
        //}

        public int Count()
        {
           return _context.Set<TEntity>().Count();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById<TId>(TId id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public bool Remove(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Set<TEntity>().Remove(entity);
            //_context.SaveChanges();
            return true;
        }

        public bool Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State=EntityState.Modified;
            //_context.SaveChanges();
            return true;
        }
    }
}
