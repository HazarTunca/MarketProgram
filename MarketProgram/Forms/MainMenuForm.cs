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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SellFormButton_Click(object sender, EventArgs e)
        {
            var form = FormUtils.OpenForm<SellForm>(null);
            form.FormClosed += OnChildFormClosed;
            this.Hide();
        }

        private void ProductsFormButton_Click(object sender, EventArgs e)
        {
            var form = FormUtils.OpenForm<ProductsForm>(null);
            form.FormClosed += OnChildFormClosed;
            this.Hide();
        }

        private void OnChildFormClosed(object? sender, FormClosedEventArgs e)
        {
            var form = sender as Form;
            form.FormClosed -= OnChildFormClosed;
            this.Show();
        }
    }
}
