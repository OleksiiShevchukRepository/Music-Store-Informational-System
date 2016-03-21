using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Entities
{
    public class CartItem
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public decimal PriceItem { get; set; }
        public decimal PriceAmount { get; set; }
        public int Amount { get; set; }
        public int AmountInShop { get; set; }
    }
}
