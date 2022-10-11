namespace MarketProgram
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Location = new System.Drawing.Point(12, 12);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(104, 40);
            this.BackToMainMenuButton.TabIndex = 0;
            this.BackToMainMenuButton.Text = "GERİ";
            this.BackToMainMenuButton.UseVisualStyleBackColor = true;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(13, 60);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(424, 23);
            this.BarcodeTextBox.TabIndex = 1;
            this.BarcodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeTextBox_KeyPress);
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceTextBox.Location = new System.Drawing.Point(12, 322);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(425, 50);
            this.TotalPriceTextBox.TabIndex = 3;
            this.TotalPriceTextBox.Text = "Total Price: 1058₺";
            this.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(174, 378);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(105, 60);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "TEMİZLE";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(13, 89);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.Size = new System.Drawing.Size(424, 227);
            this.ProductGridView.TabIndex = 5;
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Name = "SellForm";
            this.Text = "SellForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackToMainMenuButton;
        private TextBox BarcodeTextBox;
        private TextBox TotalPriceTextBox;
        private Button ClearButton;
        private DataGridView ProductGridView;
    }
}