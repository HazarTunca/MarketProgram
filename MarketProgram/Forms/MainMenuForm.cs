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
using XIV.SaveSystems;
using XIV.Utils;

namespace MarketProgram
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += MainMenuForm_FormClosed;
        }

        private void MainMenuForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            SaveSystem.Save(StoreInventory.Instance, MarketProgramPaths.BaseFolderPath);
        }

        private void SellFormButton_Click(object sender, EventArgs e)
        {
            var form = FormUtils.OpenForm<SellForm>(this.MdiParent);
            form.FormClosed += OnChildFormClosed;
            this.Hide();
        }

        private void ProductsFormButton_Click(object sender, EventArgs e)
        {
            var form = FormUtils.OpenForm<ProductsForm>(this.MdiParent);
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
