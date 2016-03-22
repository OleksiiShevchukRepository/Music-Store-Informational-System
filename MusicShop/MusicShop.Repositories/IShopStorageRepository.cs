using MusicShop.Entities;
using System.Collections.Generic;

namespace MusicShop.Repositories
{
    interface IShopStorageRepository
    {
        List<AlbumsInStorage> SelectAll();
        List<AlbumsInStorage> SelectByGenre(int genreId);
    }
}

