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

        void ToCart()
        {
            DataGridViewRow selectedRow = dataGridViewInStore.Rows[0];
            dataGridViewInCart.Rows.Add();
            dataGridViewInCart.Rows[0].Cells[0] = selectedRow.Cells[0];
        }

        public FormItemsInShop()
        {
            InitializeComponent();

            g.ShowAlbumsInStoreNoFilters(dataGridViewInStore);
            g.InsertMusicGenres(comboBoxGenre);
            //ToCart();
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)comboBoxGenre.SelectedValue == 0)
            {
                g.ShowAlbumsInStoreNoFilters(dataGridViewInStore);
            }
            else
            {
                g.ShowAlbumsInStoreByGenre(dataGridViewInStore, (int)comboBoxGenre.SelectedValue);
            }
        }
    }
}
