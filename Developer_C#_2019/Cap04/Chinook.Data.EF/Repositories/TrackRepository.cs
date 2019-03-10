using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entities.Base.Repositories
{
    public class TrackRepository
    {
        // No se puede sobre escribir en el metodo.
        // El unico lugar en donde pueso asignar un valor es en la clase
        private readonly AppDataModel _context;

        public TrackRepository()
        {
            _context = new AppDataModel();
        }

        // La cantidad de registro que tiene la tabla.
        public int Count()
        {
            return _context.Track.Count();
        }

        /*
        public IEnumerable<Track> GetAll(string nombre)
        {
            return _context.Track.ToList();
        }
        */

        // El linq no existe el LIKE sino CONTAINS
        // item => Es alias.
        //public IEnumerable<Track> GetAll(string nombre)
        //{
        //    return _context.Track
        //            .Where(item=>item.Name.Contains(nombre))
        //            .OrderBy(order=>order.Name)
        //            .ThenBy(order=>order.TrackId)
        //            .ToList();
        //}

        public IEnumerable<Track> GetAll(string nombre)
        {
            IQueryable<Track> query = _context.Track;

            // Includes (edger loading)
            query = query.Include(item => item.Album);

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                query = query.Where(a => a.Name.Contains(nombre));
            }
            // Ordenamiento
            query = query.OrderBy(o => o.Name);
            return query.ToList();
        }

        public int Insert(Track entity)
        {
            //Se agrega la informacion al contexto de EF.
            _context.Track.Add(entity);
            //Confirma la trasaccion
            _context.SaveChanges();

            return entity.TrackId;
        }

        // Attach se agrega a la memoria temporal
        public bool Update(Track entity)
        {
            // Atachando en meoria el objetyo que 
            // se quiere actualizar
            _context.Track.Attach(entity);
            // Cambiando el estado de
            // Unchanged a Modified
            _context.Entry(entity).State =
                EntityState.Modified;

            // Confirmando la operacion
            var result = _context.SaveChanges();

            return result > 0;
        }

        public bool Delete(Track entity)
        {
            // Atachando en memoria el objeto que
            // se quiere actualizar
            _context.Track.Attach(entity);
            // confirmando el estado de 
            // unchanged a deleted
            _context.Track.Remove(entity);
            // Confirmando la operacion
            var result = _context.SaveChanges();
            return result > 0;
        }

        public Track Get(int id)
        {
            return _context.Track.Find(id);
        }



    }
}
