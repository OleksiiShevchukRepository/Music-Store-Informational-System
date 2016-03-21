using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Entities;

namespace MusicShop.Repositories
{
    interface IShopStorageRepository
    {
        List<AlbumsInStorage> SelectAll();
        List<AlbumsInStorage> SelectByGenre(int genreId);
    }
}
