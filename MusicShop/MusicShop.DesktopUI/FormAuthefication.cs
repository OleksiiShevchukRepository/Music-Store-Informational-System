using MusicShop.Entities;
using MusicShop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop.DesktopUI
{
    public partial class FormAuthefication : Form
    {
        public FormAuthefication()
        {
            InitializeComponent();

            //TestRepo tr = new TestRepo(@"Server=(localdb)\MSSQLLocalDB;Database=MusicStore;Trusted_Connection=True;");
            //ICollection<AlbumsInStorage> t = tr.SelectAll();
            //buttonExit.Enabled = true;
        }
    }
}
