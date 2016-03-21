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
    public class ShopStorageRepository : IShopStorageRepository
    {
        private const string spGetAllAlbums = "spAlbumsInMusicStore_noFilters";
        private const string spGetAlbumsByGenre = "spAlbumsInMusicStore_Filters";

        private readonly string _connectionString;

        public ShopStorageRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<AlbumsInStorage> SelectAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetAllAlbums;
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<AlbumsInStorage> albums = new List<AlbumsInStorage>();
                        AlbumsInStorage album = null;

                        while (reader.Read())
                        {
                            album = new AlbumsInStorage();

                            album.AlbumId = (int)reader["id"];
                            album.AlbumName = (string)reader["albName"];
                            album.ArtistName = (string)reader["artName"];
                            album.RealisationPrise = (decimal)reader["price"];
                            album.RatingAllMusic = (int)reader["rateAllMusic"];

                            if (reader["liquidity"] != DBNull.Value)
                            {
                                album.LiquidRate = (float)reader["liquidity"];
                            }

                            album.AmountInStorage = (int)reader["amount"];
                            albums.Add(album);
                        }

                        return albums;
                    }
                }
            }
        }

        public List<AlbumsInStorage> SelectByGenre(int genreId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetAlbumsByGenre;
                    command.Parameters.AddWithValue("@GenreId", genreId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<AlbumsInStorage> albums = new List<AlbumsInStorage>();
                        AlbumsInStorage album = null;

                        while (reader.Read())
                        {
                            album = new AlbumsInStorage();

                            album.AlbumId = (int)reader["id"];
                            album.AlbumName = (string)reader["albName"];
                            album.ArtistName = (string)reader["artName"];
                            album.RealisationPrise = (decimal)reader["price"];
                            album.Genre = (string)reader["genre"];
                            album.RatingAllMusic = (int)reader["rateAllMusic"];

                            if (reader["liquidity"] != DBNull.Value)
                            {
                                album.LiquidRate = (float)reader["liquidity"];
                            }

                            album.AmountInStorage = (int)reader["amount"];
                            albums.Add(album);
                        }

                        return albums;
                    }
                }
            }
        }
    }
}
