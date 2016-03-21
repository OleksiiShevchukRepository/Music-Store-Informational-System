using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Entities;
using System.Data.SqlClient;
using System.Data;

namespace MusicShop.Repositories
{
    public class CheckRepository
    {
        private const string spCreateCheck = "spCreateCheck";
        private const string spCreateSoldItem = "spCreateSoldItem";

        private readonly string _connectionString;

        public CheckRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateCheck(int sellerId, decimal totalSum)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spCreateCheck;
                    command.Parameters.AddWithValue("@SellerId", sellerId);
                    command.Parameters.AddWithValue("@TotalSum", totalSum);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddItemToCheck(int albumId, int amount, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spCreateSoldItem;
                    command.Parameters.AddWithValue("@AlbumId", albumId);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Price", price);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

