using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository.Interface
{
    public interface IArtistRepository
    {
        bool Add(Artist entity);
        bool Update(Artist entity);
        bool Remove(Artist entity);
        int Count();
        Artist GetById(int id);
        List<Artist> GetAll();
    }
}
