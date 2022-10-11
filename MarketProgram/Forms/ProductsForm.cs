using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIV.Utils;

namespace MarketProgram
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            ProductGridView.Columns.Clear();
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_barcode", "BARKOD"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_name", "İSİM"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_price", "FİYAT"));
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm<MainMenuForm>(null);
            this.Hide();
        }
    }
}
