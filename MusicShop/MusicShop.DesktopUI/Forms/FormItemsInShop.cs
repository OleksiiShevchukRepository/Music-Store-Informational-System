using MusicShop.DesktopUI.Code;
using MusicShop.Repositories;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace MusicShop.DesktopUI
{
    public partial class FormItemsInShop : Form
    {
        GridViewer g = new GridViewer();

        public FormItemsInShop()
        {
            InitializeComponent();

            g.ShowAlbumsInStoreNoFilters(sss);
            g.InsertMusicGenres(comboBoxGenre);
            labelSeller.Text = "Seller:" + CurrentUser.Name + " " + CurrentUser.Surname;
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)comboBoxGenre.SelectedValue == 0)
            {
                g.ShowAlbumsInStoreNoFilters(sss);
            }
            else
            {
                g.ShowAlbumsInStoreByGenre(sss, (int)comboBoxGenre.SelectedValue);
            }
        }

        private void buttonToCart_Click(object sender, EventArgs e)
        {
            g.AddToCart(sss, dataGridViewInCart, labelPriceTotalValue);
        }

        private void buttonFromCart_Click(object sender, EventArgs e)
        {
            g.DeleteFromCart(dataGridViewInCart, labelPriceTotalValue);
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            g.ClearCart(dataGridViewInCart, labelPriceTotalValue);
        }

        private void buttonprintCheck_Click(object sender, EventArgs e)
        {
            CheckCreator ch = new CheckCreator(g.Cart);
            ch.CheckTran(CurrentUser.Id, g.CartSum());
            g.ShowAlbumsInStoreNoFilters(sss);
            g.ClearCart(dataGridViewInCart, labelPriceTotalValue);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            UserRepository usr = new UserRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString);
            DialogResult res = MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo);
            
            if(res == DialogResult.Yes)
            {
                usr.DeauthUser(CurrentUser.Id);
                this.Close();
            }

        }
    }
}
