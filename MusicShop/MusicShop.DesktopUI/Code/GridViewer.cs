using MusicShop.Entities;
using MusicShop.Repositories;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.DesktopUI.Code
{
    public class GridViewer
    {
        private const int genreHalfColumnWidth = 64;
        private const int albumNameColumnStandartWidth = 200;

        private List<CartItem> _cart = new List<CartItem>();

        public List<CartItem> Cart
        {
            get
            {
                return _cart;
            }
        }

        #region ShoppingCartOperations
        public decimal? CartSum()
        {
            decimal? sum = (from ct in _cart
                            select ct.PriceAmount).Sum();

            return sum;
        }

        public void AddToCart(DataGridView shopGV, DataGridView cartGV, Label totalPrice)
        {
            bool isRepeated = false;

            CartItem c = new CartItem();
            c.AlbumId = (int)shopGV.SelectedRows[0].Cells["clnAlbumId"].Value;
            c.AlbumName = (string)shopGV.SelectedRows[0].Cells["clnAlbum"].Value;
            c.ArtistName = (string)shopGV.SelectedRows[0].Cells["clnArtist"].Value;
            c.PriceItem = (decimal)shopGV.SelectedRows[0].Cells["clnPrice"].Value;
            c.Amount = 1;
            c.AmountInShop = (int)shopGV.SelectedRows[0].Cells["clnAmount"].Value;
            c.PriceAmount = c.PriceItem * c.Amount;

            // Check if adding the same album
            if (_cart.Count > 0)
            {
                for (int i = 0; i < _cart.Count; i++)
                {
                    if (c.AlbumId == _cart[i].AlbumId && c.PriceItem == _cart[i].PriceItem && c.AmountInShop > _cart[i].Amount)
                    {
                        _cart[i].Amount++;
                        _cart[i].PriceAmount = _cart[i].PriceItem * _cart[i].Amount;
                        isRepeated = true;
                        break;
                    }
                    else if (c.AlbumId == _cart[i].AlbumId && c.PriceItem == _cart[i].PriceItem)
                    {
                        MessageBox.Show("No more items in storage");
                        isRepeated = true;
                    }
                }
            }


            if (!isRepeated)
            {
                _cart.Add(c);
            }


            PrintCart(cartGV, totalPrice);
        }

        public void DeleteFromCart(DataGridView cartGV, Label totalPrice)
        {
            if (_cart.Count > 0)
            {
                if (_cart[cartGV.CurrentRow.Index].Amount > 1)
                {
                    _cart[cartGV.CurrentRow.Index].Amount--;
                    _cart[cartGV.CurrentRow.Index].PriceAmount = _cart[cartGV.CurrentRow.Index].PriceItem * _cart[cartGV.CurrentRow.Index].Amount;
                }
                else
                {
                    _cart.RemoveAt(cartGV.CurrentRow.Index);
                }

                PrintCart(cartGV, totalPrice);
            }
        }

        public void ClearCart(DataGridView cartGV, Label totalPrice)
        {
            _cart = new List<CartItem>();
            PrintCart(cartGV, totalPrice);
        }

        private void PrintCart(DataGridView cartGV, Label totalPrice)
        {
            cartGV.Rows.Clear();

            for (int i = 0; i < _cart.Count; i++)
            {
                cartGV.Rows.Add();
                cartGV.Rows[i].Cells["clnAlbumCart"].Value = _cart[i].AlbumName;
                cartGV.Rows[i].Cells["clnAmountCart"].Value = _cart[i].Amount;
                cartGV.Rows[i].Cells["clnAlbumIdCart"].Value = _cart[i].AlbumId;
                cartGV.Rows[i].Cells["clnPriceCart"].Value = _cart[i].PriceItem;
                cartGV.Rows[i].Cells["clnPriceTotal"].Value = _cart[i].PriceAmount;
            }

            totalPrice.Text = CartSum().ToString();
        }

        #endregion

        #region MusicGenresInsertion

        public void InsertMusicGenres(ComboBox cb)
        {
            GenreRepository gr = new GenreRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString);
            Dictionary<int, string> dg = gr.SelectAll();

            cb.DataSource = new BindingSource(dg, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }

        #endregion

        #region ShowAlbumsInStore

        public void ShowAlbumsInStoreNoFilters(DataGridView gridView)
        {
            ShopStorageRepository ssr = new ShopStorageRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString);
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
                gridView.Rows[i].Cells["clnAlbumId"].Value = ais[i].AlbumId;
                gridView.Rows[i].Cells["clnAlbum"].Value = ais[i].AlbumName;
                gridView.Rows[i].Cells["clnArtist"].Value = ais[i].ArtistName;
                gridView.Rows[i].Cells["clnPrice"].Value = ais[i].RealisationPrise;
                gridView.Rows[i].Cells["clnRating"].Value = ais[i].RatingAllMusic;
                gridView.Rows[i].Cells["clnAmount"].Value = ais[i].AmountInStorage;
            }
        }

        public void ShowAlbumsInStoreByGenre(DataGridView gridView, int genreId)
        {
            ShopStorageRepository ssr = new ShopStorageRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString);
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
                gridView.Rows[i].Cells["clnAlbumId"].Value = ais[i].AlbumId;
                gridView.Rows[i].Cells["clnAlbum"].Value = ais[i].AlbumName;
                gridView.Rows[i].Cells["clnArtist"].Value = ais[i].ArtistName;
                gridView.Rows[i].Cells["clnPrice"].Value = ais[i].RealisationPrise;
                gridView.Rows[i].Cells["clnGenre"].Value = ais[i].Genre;
                gridView.Rows[i].Cells["clnRating"].Value = ais[i].RatingAllMusic;
                gridView.Rows[i].Cells["clnAmount"].Value = ais[i].AmountInStorage;
            }
        }
    }

    #endregion
}

