using MusicShop.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Repositories
{
    public class UserRepository : IUserRepository
    {
        // review O.S: use base class for this members
        private const string spGetUserByLogin = "spGetUserByLogin";
        private const string spInitUser = "spAuthUser";
        private const string spDeauthUser = "spDeauthUser";

        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Methods

        public User GetUserByLogin(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetUserByLogin;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;
                        if (reader.Read())
                        {
                            user = new User();
                            user.Id = (int)reader["Id"];
                            user.Name = (string)reader["Name"];
                            user.Surname = (string)reader["Surname"];
                            user.Disabled = (bool)reader["Disabled"];
                        }

                        return user;
                    }
                }
            }
        }

        public void InitUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spInitUser;
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeauthUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spDeauthUser;
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}
