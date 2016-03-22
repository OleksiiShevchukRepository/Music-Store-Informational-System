namespace MusicShop.Entities
{
    /// <summary>
    /// Represents "tblGenre" table in DB.
    /// </summary>
    public class Genre
    {
        public Genre() { }

        public Genre(int id, string name)
        {
            id = Id;
            name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
