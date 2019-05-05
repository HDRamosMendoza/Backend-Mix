using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.WCFLib.Interfaces
{
    public partial interface IMantenimientosService
    {
        [OperationContract]
        IEnumerable<Artist> GetArtistAll(string nombre);
        // Definimos el contrato

        [OperationContract]
        Artist GetArtistById(int id);

        [OperationContract]
        bool SaveArtist(Artist artist);

        [OperationContract]
        bool DeleteArtist(int id);

    }
}