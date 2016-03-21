using MusicShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Repositories;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Transactions;

namespace MusicShop.DesktopUI.Code
{
    public class CheckCreator
    {
        private readonly List<CartItem> _cart;
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=MusicStore;Trusted_Connection=True;";

        private CheckRepository ch = new CheckRepository(@"Server=(localdb)\MSSQLLocalDB;Database=MusicStore;Trusted_Connection=True;");

        public CheckCreator(List<CartItem> cartItems)
        {
            _cart = cartItems;
        }

        public void CheckTran(int sellerId, decimal? sumAmount)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    CreateCheck(sellerId, (decimal)sumAmount);
                    FillCheckIn();

                    scope.Complete();
                }       
            }
            catch (TransactionAbortedException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        } 

        private void CreateCheck(int sellerId, decimal sumAmount)
        {
            ch.CreateCheck(sellerId, sumAmount);
        }

        private void FillCheckIn()
        {
            foreach(CartItem c in _cart)
            {
                ch.AddItemToCheck(c.AlbumId, c.Amount, c.PriceAmount);
            }
        }
    }


}
