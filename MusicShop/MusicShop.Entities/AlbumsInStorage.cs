namespace MusicShop.Entities
{
    public class AlbumsInStorage
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public decimal RealisationPrise { get; set; }
        public int RatingAllMusic { get; set; }
        public int AmountInStorage { get; set; }
    }
}
