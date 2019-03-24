using App.Data.Repository.Interface;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public TEntity FindEntity(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordersBy = null, string include = "")
        {
            throw new NotImplementedException();
        }

        public TEntity FindEntity(Expression<Func<TEntity, bool>> filters)
        {
            
            return _context.Set<TEntity>().Where(filters).FirstOrDefault();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
            
        }

        public List<TEntity> GetAll(
            Expression<Func<TEntity, bool>> filters = null,
            Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> ordersBy = null,
            Expression<Func<TEntity,TEntity>> selects=null,
            string include = "")
        {
             IQueryable<TEntity> query = _context.Set<TEntity>();

            if (filters != null)
            {
                query = query.Where(filters);
            }

            // Los select se agregan despues del where.
            if (selects!=null)
            {
                query = query.Select(selects);
            }

            foreach (var includeProperies in include.Split(
                new char[] { ','},
                StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperies);

            }
            

            if (ordersBy!=null)
            {
                return ordersBy(query).ToList();
            } else {
                return query.ToList();
            }         
        }

        //return _context.Set<TEntity>().Where(filters).FirstOrDefault();
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
