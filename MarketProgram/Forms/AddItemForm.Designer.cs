namespace MarketProgram.Forms
{
    partial class AddItemForm
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
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.lbl_BarcodeID = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txt_BarcodeID = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddProduct.Location = new System.Drawing.Point(68, 257);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(120, 48);
            this.btn_AddProduct.TabIndex = 0;
            this.btn_AddProduct.Text = "Ekle";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // lbl_BarcodeID
            // 
            this.lbl_BarcodeID.AutoSize = true;
            this.lbl_BarcodeID.Location = new System.Drawing.Point(12, 9);
            this.lbl_BarcodeID.Name = "lbl_BarcodeID";
            this.lbl_BarcodeID.Size = new System.Drawing.Size(44, 15);
            this.lbl_BarcodeID.TabIndex = 1;
            this.lbl_BarcodeID.Text = "Barkod";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(12, 65);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(54, 15);
            this.lbl_ProductName.TabIndex = 2;
            this.lbl_ProductName.Text = "Ürün Adı";
            // 
            // txt_BarcodeID
            // 
            this.txt_BarcodeID.Location = new System.Drawing.Point(12, 27);
            this.txt_BarcodeID.Name = "txt_BarcodeID";
            this.txt_BarcodeID.Size = new System.Drawing.Size(176, 23);
            this.txt_BarcodeID.TabIndex = 3;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(12, 83);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(176, 23);
            this.txt_ProductName.TabIndex = 4;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(12, 140);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(176, 23);
            this.txt_Price.TabIndex = 6;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(12, 122);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(32, 15);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Fiyat";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(12, 201);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(176, 23);
            this.txt_Amount.TabIndex = 8;
            this.txt_Amount.Text = "0";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(12, 183);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(41, 15);
            this.lbl_Amount.TabIndex = 7;
            this.lbl_Amount.Text = "Miktar";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 327);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_BarcodeID);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_BarcodeID);
            this.Controls.Add(this.btn_AddProduct);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AddProduct;
        private Label lbl_BarcodeID;
        private Label lbl_ProductName;
        private TextBox txt_BarcodeID;
        private TextBox txt_ProductName;
        private TextBox txt_Price;
        private Label lbl_Price;
        private TextBox txt_Amount;
        private Label lbl_Amount;
    }
}