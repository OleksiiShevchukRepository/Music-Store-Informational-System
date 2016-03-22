using System;

namespace MusicShop.Repositories
{
    public class Check
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public decimal SumTotal { get; set; }
        public DateTime DateStatement { get; set; }
    }
}
