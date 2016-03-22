using System;

namespace MusicShop.Repositories
{
    /// <summary>
    /// Represents a check template.
    /// </summary>
    public class Check
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public decimal SumTotal { get; set; }
        public DateTime DateStatement { get; set; }
    }
}
