namespace MarketProgram
{
    partial class ProductsForm
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
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Location = new System.Drawing.Point(12, 12);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(109, 43);
            this.BackToMainMenuButton.TabIndex = 0;
            this.BackToMainMenuButton.Text = "GERİ";
            this.BackToMainMenuButton.UseVisualStyleBackColor = true;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Location = new System.Drawing.Point(681, 12);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(107, 43);
            this.RemoveProductButton.TabIndex = 1;
            this.RemoveProductButton.Text = "ÇIKAR";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(568, 12);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(107, 43);
            this.UpdateProductButton.TabIndex = 2;
            this.UpdateProductButton.Text = "GÜNCELLE";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(455, 12);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(107, 43);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "EKLE";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(12, 61);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.Size = new System.Drawing.Size(776, 377);
            this.ProductGridView.TabIndex = 4;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.RemoveProductButton);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BackToMainMenuButton;
        private Button RemoveProductButton;
        private Button UpdateProductButton;
        private Button AddProductButton;
        private DataGridView ProductGridView;
    }
}