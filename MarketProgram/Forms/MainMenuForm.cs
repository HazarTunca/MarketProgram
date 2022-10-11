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
            FormUtils.OpenForm<SellForm>(null);
            this.Hide();
        }

        private void ProductsFormButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm<ProductsForm>(null);
            this.Hide();
        }
    }
}
