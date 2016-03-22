using MusicShop.Entities;
using MusicShop.Repositories;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MusicShop.DesktopUI.Code
{
    public class Printer
    {
        private const int offsetDown = 5;
        private const int itemPadRight = 40;
        private const int amountPadRight = 15;
        private const int totalPadRight = 65;
        private const int checkIdPadRight = 10;

        private readonly List<CartItem> _cart;
        private Check _check;

        public Printer(List<CartItem> cartItems)
        {
            _cart = cartItems;
            _check = new CheckRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString).GetCheckInfo();
        }

        public void Print()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            // Add the document to the dialog box.
            printDialog.Document = printDocument; 

            printDocument.PrintPage += new PrintPageEventHandler(CreateCheckTemplate);

            DialogResult dr = printDialog.ShowDialog();

            if(dr == DialogResult.OK)
            {
                printDocument.Print();
            }
            else
            {
                MessageBox.Show("Customer refused from check. Operation Completed");
            }
            
        }

        #region CheckTemplate
        private void CreateCheckTemplate(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Times New Roman", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("H2O licenced CD's", new Font("Times New Roman", 18), new SolidBrush(Color.Black), startX, startY);

            string top = "Item Name".PadRight(itemPadRight) + "Amount".PadRight(amountPadRight) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-----------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + offsetDown; //make the spacing consistent

            foreach(CartItem c in _cart)
            {
                string s = c.AlbumName.PadRight(itemPadRight) + c.Amount.ToString().PadRight(amountPadRight) + c.PriceAmount.ToString();
                graphic.DrawString(s, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + offsetDown; //make the spacing consistent
            }

            graphic.DrawString("-----------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + offsetDown; //make the spacing consistent
            string total = "Total:".PadRight(totalPadRight) + _check.SumTotal;
            graphic.DrawString(total, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + offsetDown;
            graphic.DrawString("-----------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + offsetDown;
            string checkInfo = _check.Id.ToString().PadRight(checkIdPadRight) +
                _check.SellerName.PadRight(amountPadRight) + _check.SellerSurname.PadRight(amountPadRight) + _check.DateStatement;
            graphic.DrawString(checkInfo, font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        #endregion
    }
}
