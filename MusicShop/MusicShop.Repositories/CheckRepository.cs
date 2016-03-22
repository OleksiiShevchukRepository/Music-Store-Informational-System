using System;
using System.Data;
using System.Data.SqlClient;

namespace MusicShop.Repositories
{
    public class CheckRepository
    {
        private const string spCreateCheck = "spCreateCheck";
        private const string spCreateSoldItem = "spCreateSoldItem";
        private const string spCheckInfo = "spCheckInfo";

        private readonly string _connectionString;

        public CheckRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region CheckCreation

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

        #endregion

        #region CheckExecution
        public Check GetCheckInfo()
        {
            Check check = new Check();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spCheckInfo;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            check.Id = (int)reader["id"];
                            check.SellerName = (string)reader["name"];
                            check.SellerSurname = (string)reader["surname"];
                            check.SumTotal = (decimal)reader["total"];
                            check.DateStatement = (DateTime)reader["date"];
                        }
                    }
                }
            }

            return check;
        }

        #endregion
    }
}

