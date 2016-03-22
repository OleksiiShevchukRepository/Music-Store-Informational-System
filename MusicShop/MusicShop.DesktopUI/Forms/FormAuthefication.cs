using MusicShop.DesktopUI.Code;
using MusicShop.Entities;
using MusicShop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MusicShop.DesktopUI
{
    public partial class FormAuthefication : Form
    {
        private readonly UserRepository _usr;

        public FormAuthefication()
        {
            _usr = new UserRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString);

            InitializeComponent();
        }

        #region Buttons

        private void ToMainForm()
        {
            var frm = new FormItemsInShop();
            frm.FormClosing += delegate { Show(); };
            frm.Show();
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxUser.Text;
            string password = textBoxPassword.Text;
            using (MD5 md5hash = MD5.Create())
            {
                password = CurrentUser.GetMd5Hash(md5hash, password);
            }

            User user = _usr.GetUserByLogin(login, password);
            if (user == null)
            {
                MessageBox.Show(this, "Invalid user name or password or user is already authificated", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _usr.InitUser(user.Id);
                CurrentUser.Initialize(user);
                DialogResult = DialogResult.OK;
                ToMainForm();
            }
        }

        private void FormAuthefication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        #endregion
    }
}
