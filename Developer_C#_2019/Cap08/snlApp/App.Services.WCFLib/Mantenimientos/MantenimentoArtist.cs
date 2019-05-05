using App.Domain;
using App.Domain.Interfaces;
using App.Entities.Base;
using App.Services.WCFLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.WCFLib
{
    public partial class MantenimentosService : IMantenimientosService
    {
        public bool DeleteArtist(int id)
        {
            IArtistDomain domain = new ArtistDomain();
            return domain.DeleteArtist(id);
        }

        public Artist GetArtistById(int id)
        {
            IArtistDomain artist = new ArtistDomain();
            return artist.GetArtistById(id);
        }

        public IEnumerable<Artist> GetArtistAll(string nombre)
        {
            IArtistDomain domain = new ArtistDomain();
            return domain.GetArtist(nombre);
        }

        public bool SaveArtist(Artist entity)
        {
            IArtistDomain domain = new ArtistDomain();
            return domain.SaveArtist(entity);
        }
    }
}
