using System;
using System.Collections.Generic;
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
        public IEnumerable<Artist> GetAll(string nombre)
        {
            return _context.Artist
                    .Where(item=>item.Name.Contains(nombre))
                    .OrderBy(order=>order.Name)
                    .ThenBy(order=>order.ArtistId)
                    .ToList();
        }



    }
}
