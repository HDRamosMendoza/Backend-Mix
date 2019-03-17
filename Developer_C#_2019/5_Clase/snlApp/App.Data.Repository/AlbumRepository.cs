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
    // IMPLEMENTAS
    public class AlbumRepository:GenericRepository<Album>
        , IAlbumRepository
    {
        // Tenemos en interfaz
        public AlbumRepository(DbContext context) : base(context)
        {

        }
    }
}
