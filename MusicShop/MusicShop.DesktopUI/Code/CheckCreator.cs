using MusicShop.Entities;
using MusicShop.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Transactions;
using System.Windows.Forms;

namespace MusicShop.DesktopUI.Code
{
    public class CheckCreator
    {
        private readonly List<CartItem> _cart;

        private CheckRepository ch = new CheckRepository(ConfigurationManager.ConnectionStrings["MusicStore"].ConnectionString);

        public CheckCreator(List<CartItem> cartItems)
        {
            _cart = cartItems;
        }

        #region Transaction

        public void CheckTran(int sellerId, decimal? sumAmount)
        {
            if (_cart.Count > 0)
            {
                try
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        ApplyChangesToStorage();
                        CreateCheck(sellerId, (decimal)sumAmount);
                        FillCheckIn();
                        Printer p = new Printer(_cart);
                        p.Print();
                        ClearStorage();

                        scope.Complete();
                    }
                }
                catch (TransactionAbortedException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Shopping car is empty");
            }
        }

        #endregion

        #region TransactionMethods

        private void ClearStorage()
        {
            ch.ClearShopStorage();
        }

        private void CreateCheck(int sellerId, decimal sumAmount)
        {
            ch.CreateCheck(sellerId, sumAmount);
        }

        private void FillCheckIn()
        {
            foreach(CartItem c in _cart)
            {
                ch.AddItemToCheck(c.AlbumId, c.Amount, c.PriceAmount);
            }
        }

        private void ApplyChangesToStorage()
        {
            foreach (CartItem c in _cart)
            {
                ch.UpdateShowStorage(c.AlbumId, c.PriceItem, c.Amount);
            }
        }

        #endregion

    }


}
