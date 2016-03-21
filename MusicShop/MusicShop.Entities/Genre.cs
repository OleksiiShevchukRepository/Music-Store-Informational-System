using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Entities
{
    public class Genre
    {
        public Genre() { }

        public Genre(int id, string name)
        {
            id = Id;
            name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
