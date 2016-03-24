using MusicShop.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MusicShop.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        // review O.S: use base class for this members
        private const string spGetAllGenres = "spSelectAllFromGenre";

        private readonly string _connectionString;

        public GenreRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Dictionary<int, string> SelectAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // review O.S: Missed space
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetAllGenres;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var genres = new Dictionary<int, string>();

                        genres.Add(0, "Any Genre");
                        Genre genre = null;

                        while (reader.Read())
                        {
                            genre = new Genre();
                            genre.Id = (int)reader["Id"];
                            genre.Name = (string)reader["Name"];
                            genres.Add(genre.Id, genre.Name);
                        }

                        return genres;
                    }
                }
            }
        }
    }
}
