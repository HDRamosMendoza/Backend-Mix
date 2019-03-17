using App.Data.Repository.Interface;
using System.Data.Entity;
using System.Collections.Generic;
using App.Entities.Base;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity>
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
            //Confirmando lso cambios
            _context.SaveChanges();
            return true;
        }


    }
}
