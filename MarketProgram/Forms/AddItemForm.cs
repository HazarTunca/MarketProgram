using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketProgram.Store;
using MarketProgram.Store.Interfaces;
using XIV.Utils;

namespace MarketProgram.Forms
{
    public partial class AddItemForm : Form
    {
        public IInventoryChangedListener InventoryChangedListener { get; set; }

        public AddItemForm()
        {
            InitializeComponent();
            txt_Price.LostFocus += Txt_Price_LostFocus;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_BarcodeID.Text))
            {
                MessageUtils.ShowError(StringConstants.Title_Error, StringConstants.Error_Invalid_BarcodeID);
                return;
            }
            if (string.IsNullOrEmpty(txt_ProductName.Text))
            {
                MessageUtils.ShowError(StringConstants.Title_Error, StringConstants.Error_Invalid_ProductName);
                return;
            }
            if (string.IsNullOrEmpty(txt_Price.Text) || double.TryParse(txt_Price.Text, out var price) == false)
            {
                MessageUtils.ShowError(StringConstants.Title_Error, StringConstants.Error_Invalid_Price);
                return;
            }
            if (string.IsNullOrEmpty(txt_Amount.Text) || uint.TryParse(txt_Amount.Text, out var count) == false)
            {
                MessageUtils.ShowError(StringConstants.Title_Error, StringConstants.Error_Invalid_ItemAmount);
                return;
            }

            if (StoreInventory.Instance.Contains(txt_BarcodeID.Text))
            {
                var result = MessageUtils.YesNoFeedback.ShowWarning(StringConstants.Title_Warning, StringConstants.Warning_ItemAlreadyExist + " " + StringConstants.Warning_UpdateItem, null, null);
                if (result == DialogResult.Yes)
                {
                    StoreInventory.Instance.UpdateProduct(txt_BarcodeID.Text, new ProductData(txt_BarcodeID.Text, txt_ProductName.Text, price, count));
                    InventoryChangedListener.OnInventoryChanged(StoreInventory.Instance);
                    MessageUtils.ShowInfo(StringConstants.Title_Success, StringConstants.Success_ItemUpdated);
                }
            }
            else
            {
                StoreInventory.Instance.AddProduct(txt_BarcodeID.Text, txt_ProductName.Text, price, count);
                InventoryChangedListener.OnInventoryChanged(StoreInventory.Instance);
                MessageUtils.ShowInfo(StringConstants.Title_Success, StringConstants.Success_ItemAdded);
            }

        }

        private void Txt_Price_LostFocus(object? sender, EventArgs e)
        {
            txt_Price.Text = txt_Price.Text.Replace(',', '.');
        }
    }
}
