using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Entities
{
    public class SoldAlbums
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int CheckId { get; set; }
        public int Amount { get; set; }
        public DateTime SellDate { get; set; }
        public decimal Sum { get; set; }
    }
}
