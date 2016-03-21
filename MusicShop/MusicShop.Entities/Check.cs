using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Repositories
{
    public class Check
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public decimal SumTotal { get; set; }
        public DateTime DateStatement { get; set; }
    }
}
