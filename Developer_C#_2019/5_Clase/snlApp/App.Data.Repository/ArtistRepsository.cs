using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class ArtistRepsository: GenericRepository<Artist>, IArtistRepository
    {
        _context =  context;
    }
}
