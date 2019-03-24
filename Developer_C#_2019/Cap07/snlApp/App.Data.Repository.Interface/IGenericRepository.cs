using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository.Interface
{
    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        int Count();
        TEntity GetById<TId>(TId id);
        List<TEntity> GetAll();

        /// <summary>
        /// Permite obtener la lista de datos
        /// </summary>
        /// <param name="filter">Se especifica los fioltroa de la consulta</param>
        /// <param name="ordersBy">Se especifica lo campos a ordenar</param>
        /// <param name="include">Se indican las entidades que sevan a relacionar</param>
        /// <returns></returns>
        List<TEntity> GetAll(
            Expression<Func<TEntity, bool>> filters = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordersBy = null,
            Expression<Func<TEntity, TEntity>> selects = null,
            string include = ""
        );

        // Es para N filtros
        TEntity FindEntity(Expression<Func<TEntity, bool>> filter);

    }
}
