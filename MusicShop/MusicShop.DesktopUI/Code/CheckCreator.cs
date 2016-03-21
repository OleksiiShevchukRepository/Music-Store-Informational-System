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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction tran = connection.BeginTransaction();

                try
                {
                    CreateCheck(sellerId, (decimal)sumAmount, connection, command);
                    FillCheckIn(connection, command);

                    tran.Commit();
                }
                catch
                {
                    MessageBox.Show("Error creating check. Please, try again");

                    try
                    {
                        tran.Rollback();
                    }
                    catch(Exception exRollback)
                    {
                        MessageBox.Show(exRollback.Message);
                    }
                }
            }

        } 

        private void CreateCheck(int sellerId, decimal sumAmount, SqlConnection connection, SqlCommand command)
        {
            ch.CreateCheck(sellerId, sumAmount, connection, command);
        }

        private void FillCheckIn(SqlConnection connection, SqlCommand command)
        {
            foreach(CartItem c in _cart)
            {
                ch.AddItemToCheck(c.AlbumId, c.Amount, c.PriceAmount, connection, command);
            }
        }
    }


}
