using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicShop.Repositories;
using MusicShop.Entities;
using System.Collections;
using MusicShop.DesktopUI.Code;

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
            ch.CheckTran(1, g.CartSum());
            g.ShowAlbumsInStoreNoFilters(sss);
            g.ClearCart(dataGridViewInCart, labelPriceTotalValue);
        }
    }
}
