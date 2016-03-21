using MusicShop.Entities;
using MusicShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop.DesktopUI.Code
{ 
    public class GridViewer
    {
        private const int genreHalfColumnWidth = 64;
        private const int albumNameColumnStandartWidth = 200;

        public void InsertMusicGenres(ComboBox cb)
        {
            GenreRepository gr = new GenreRepository(@"Server=(localdb)\MSSQLLocalDB;Database=MusicStore;Trusted_Connection=True;");
            Dictionary<int, string> dg = gr.SelectAll();

            cb.DataSource = new BindingSource(dg, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }

        public void ShowAlbumsInStoreNoFilters(DataGridView gridView)
        {
            ShopStorageRepository ssr = new ShopStorageRepository(@"Server=(localdb)\MSSQLLocalDB;Database=MusicStore;Trusted_Connection=True;");
            List<AlbumsInStorage> ais = ssr.SelectAll();

            // No genre show.
            gridView.Columns["clnGenre"].Visible = false;
            // Make columns wider to pass the gridView size.
            if (gridView.Columns["clnAlbum"].Width == albumNameColumnStandartWidth)
            {
                gridView.Columns["clnAlbum"].Width += genreHalfColumnWidth;
                gridView.Columns["clnArtist"].Width += genreHalfColumnWidth;
            }

            gridView.Rows.Clear();

            for (int i = 0; i < ais.Count; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Cells["clnAlbum"].Value = ais[i].AlbumName;
                gridView.Rows[i].Cells["clnArtist"].Value = ais[i].ArtistName;
                gridView.Rows[i].Cells["clnPrice"].Value = ais[i].RealisationPrise;
                gridView.Rows[i].Cells["clnRating"].Value = ais[i].RatingAllMusic;
                gridView.Rows[i].Cells["clnAmount"].Value = ais[i].AmountInStorage;
            }
        }

        public void ShowAlbumsInStoreByGenre(DataGridView gridView, int genreId)
        {
            ShopStorageRepository ssr = new ShopStorageRepository(@"Server=(localdb)\MSSQLLocalDB;Database=MusicStore;Trusted_Connection=True;");
            List<AlbumsInStorage> ais = ssr.SelectByGenre(genreId);

            gridView.Columns["clnGenre"].Visible = true;
            if (gridView.Columns["clnAlbum"].Width > albumNameColumnStandartWidth)
            {
                gridView.Columns["clnAlbum"].Width -= genreHalfColumnWidth;
                gridView.Columns["clnArtist"].Width -= genreHalfColumnWidth;
            }

            gridView.Rows.Clear();

            for (int i = 0; i < ais.Count; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Cells["clnAlbum"].Value = ais[i].AlbumName;
                gridView.Rows[i].Cells["clnArtist"].Value = ais[i].ArtistName;
                gridView.Rows[i].Cells["clnPrice"].Value = ais[i].RealisationPrise;
                gridView.Rows[i].Cells["clnGenre"].Value = ais[i].Genre;
                gridView.Rows[i].Cells["clnRating"].Value = ais[i].RatingAllMusic;
                gridView.Rows[i].Cells["clnAmount"].Value = ais[i].AmountInStorage;
            }
        }
    }
}
