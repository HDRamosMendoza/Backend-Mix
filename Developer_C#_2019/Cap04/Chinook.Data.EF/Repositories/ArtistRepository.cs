using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entities.Base.Repositories
{
    public class ArtistRepository
    {
        // No se puede sobre escribir en el metodo.
        // El unico lugar en donde pueso asignar un valor es en la clase
        private readonly AppDataModel _context;

        public ArtistRepository()
        {
            _context = new AppDataModel();
        }

        // La cantidad de registro que tiene la tabla.
        public int Count()
        {
            return _context.Artist.Count();
        }

        /*
        public IEnumerable<Artist> GetAll(string nombre)
        {
            return _context.Artist.ToList();
        }
        */

        // El linq no existe el LIKE sino CONTAINS
        // item => Es alias.
        //public IEnumerable<Artist> GetAll(string nombre)
        //{
        //    return _context.Artist
        //            .Where(item=>item.Name.Contains(nombre))
        //            .OrderBy(order=>order.Name)
        //            .ThenBy(order=>order.ArtistId)
        //            .ToList();
        //}

        public IEnumerable<Artist> GetAll(string nombre)
        {
            IQueryable<Artist> query = _context.Artist;
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                query = query.Where(a => a.Name.Contains(nombre));
            }
            // Ordenamiento
            query = query.OrderBy(o => o.Name);
            return query.ToList();
        }

        public int Insert(Artist entity)
        {
            //Se agrega la informacion al contexto de EF.
            _context.Artist.Add(entity);
            //Confirma la trasaccion
            _context.SaveChanges();

            return entity.ArtistId;
        }

        // Attach se agrega a la memoria temporal
        public bool Update(Artist entity)
        {
            // Atachando en meoria el objetyo que 
            // se quiere actualizar
            _context.Artist.Attach(entity);
            // Cambiando el estado de
            // Unchanged a Modified
            _context.Entry(entity).State =
                EntityState.Modified;

            // Confirmando la operacion
            var result = _context.SaveChanges();

            return result > 0;
        }

        public bool Delete(Artist entity)
        {
            // Atachando en memoria el objeto que
            // se quiere actualizar
            _context.Artist.Attach(entity);
            // confirmando el estado de 
            // unchanged a deleted
            _context.Artist.Remove(entity);
            // Confirmando la operacion
            var result = _context.SaveChanges();
            return result > 0;
        }

        public Artist Get(int id)
        {
            return _context.Artist.Find(id);
        }



    }
}
