using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketProgram.Forms;
using MarketProgram.Store;
using MarketProgram.Store.Interfaces;
using XIV.Utils;

namespace MarketProgram
{
    public partial class ProductsForm : Form, IInventoryChangedListener
    {
        public ProductsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            ProductGridView.Columns.Clear();
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_barcode", "BARKOD"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_name", "İSİM"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_price", "FİYAT"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_count", "MİKTAR"));

            RefreshDataGrid();
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm<MainMenuForm>(this.MdiParent);
            this.Hide();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var form = FormUtils.OpenForm<AddItemForm>(this.MdiParent);
            form.InventoryChangedListener = this;
        }

        public void OnInventoryChanged(StoreInventory storeInventory)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            ProductGridView.Rows.Clear();
            foreach (var productData in StoreInventory.Instance.Products())
            {
                var row = DataGridUtils.CreateRow(new object[]
                {
                    productData.barcodeID,
                    productData.productName,
                    productData.price.ToString(),
                    productData.count,
                }, true);
                ProductGridView.Rows.Add(row);
            }
        }
    }
}
