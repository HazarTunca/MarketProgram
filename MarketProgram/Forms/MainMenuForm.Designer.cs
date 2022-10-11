namespace MarketProgram
{
    partial class MainMenuForm
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
            this.SellFormButton = new System.Windows.Forms.Button();
            this.ProductsFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SellFormButton
            // 
            this.SellFormButton.Location = new System.Drawing.Point(164, 145);
            this.SellFormButton.Name = "SellFormButton";
            this.SellFormButton.Size = new System.Drawing.Size(203, 120);
            this.SellFormButton.TabIndex = 0;
            this.SellFormButton.Text = "SATIŞ";
            this.SellFormButton.UseVisualStyleBackColor = true;
            this.SellFormButton.Click += new System.EventHandler(this.SellFormButton_Click);
            // 
            // ProductsFormButton
            // 
            this.ProductsFormButton.Location = new System.Drawing.Point(396, 145);
            this.ProductsFormButton.Name = "ProductsFormButton";
            this.ProductsFormButton.Size = new System.Drawing.Size(203, 120);
            this.ProductsFormButton.TabIndex = 1;
            this.ProductsFormButton.Text = "ÜRÜNLER";
            this.ProductsFormButton.UseVisualStyleBackColor = true;
            this.ProductsFormButton.Click += new System.EventHandler(this.ProductsFormButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductsFormButton);
            this.Controls.Add(this.SellFormButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button SellFormButton;
        private Button ProductsFormButton;
    }
}