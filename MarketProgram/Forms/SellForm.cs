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
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            ProductGridView.Columns.Clear();
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_barcode", "BARKOD"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_name", "İSİM"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_price", "FİYAT"));
            ProductGridView.Columns.Add(DataGridUtils.CreateColumn("product_amount", "MİKTAR"));
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm<MainMenuForm>(null);
            this.Hide();
        }

        private void BarcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string barcode = BarcodeTextBox.Text;
                ProductGridView.Rows.Add(DataGridUtils.CreateRow(4, true));

                int lastRowIndex = ProductGridView.RowCount - 1;
                ProductGridView.Rows[lastRowIndex].Cells[0].Value = barcode;
                ProductGridView.Rows[lastRowIndex].Cells[1].Value = "amk";
                ProductGridView.Rows[lastRowIndex].Cells[2].Value = "31₺";
                ProductGridView.Rows[lastRowIndex].Cells[3].Value = "x31";
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
