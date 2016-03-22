using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Repositories
{
    /// <summary>
    /// Operations with genres.
    /// </summary>
    public interface IGenreRepository
    {
        Dictionary<int, string> SelectAll();
    }
}
