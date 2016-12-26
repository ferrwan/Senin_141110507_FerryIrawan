namespace Latihan_POS.View
{
    partial class ProductForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.hargaHPPBarangTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.hargaJualBarangTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.addProductBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelAddProductBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.productCodeTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.productNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.productInitialAmountTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.productHppPriceTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.productSellingPriceTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.idProductLabel = new MaterialSkin.Controls.MaterialLabel();
            this.idProductValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(168, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Code";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(168, 146);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(168, 210);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(103, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Initial Amount";
            // 
            // hargaHPPBarangTextBox
            // 
            this.hargaHPPBarangTextBox.AutoSize = true;
            this.hargaHPPBarangTextBox.Depth = 0;
            this.hargaHPPBarangTextBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.hargaHPPBarangTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hargaHPPBarangTextBox.Location = new System.Drawing.Point(168, 269);
            this.hargaHPPBarangTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hargaHPPBarangTextBox.Name = "hargaHPPBarangTextBox";
            this.hargaHPPBarangTextBox.Size = new System.Drawing.Size(76, 19);
            this.hargaHPPBarangTextBox.TabIndex = 0;
            this.hargaHPPBarangTextBox.Text = "HPP Price";
            // 
            // hargaJualBarangTextBox
            // 
            this.hargaJualBarangTextBox.AutoSize = true;
            this.hargaJualBarangTextBox.Depth = 0;
            this.hargaJualBarangTextBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.hargaJualBarangTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hargaJualBarangTextBox.Location = new System.Drawing.Point(168, 328);
            this.hargaJualBarangTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hargaJualBarangTextBox.Name = "hargaJualBarangTextBox";
            this.hargaJualBarangTextBox.Size = new System.Drawing.Size(92, 19);
            this.hargaJualBarangTextBox.TabIndex = 0;
            this.hargaJualBarangTextBox.Text = "Selling Price";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Depth = 0;
            this.addProductBtn.Location = new System.Drawing.Point(387, 171);
            this.addProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Primary = true;
            this.addProductBtn.Size = new System.Drawing.Size(113, 42);
            this.addProductBtn.TabIndex = 6;
            this.addProductBtn.Text = "Save";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // cancelAddProductBtn
            // 
            this.cancelAddProductBtn.Depth = 0;
            this.cancelAddProductBtn.Location = new System.Drawing.Point(387, 243);
            this.cancelAddProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelAddProductBtn.Name = "cancelAddProductBtn";
            this.cancelAddProductBtn.Primary = true;
            this.cancelAddProductBtn.Size = new System.Drawing.Size(113, 42);
            this.cancelAddProductBtn.TabIndex = 7;
            this.cancelAddProductBtn.Text = "Cancel";
            this.cancelAddProductBtn.UseVisualStyleBackColor = true;
            this.cancelAddProductBtn.Click += new System.EventHandler(this.cancelAddProductBtn_Click);
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Depth = 0;
            this.productCodeTextBox.Hint = "";
            this.productCodeTextBox.Location = new System.Drawing.Point(172, 109);
            this.productCodeTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.PasswordChar = '\0';
            this.productCodeTextBox.SelectedText = "";
            this.productCodeTextBox.SelectionLength = 0;
            this.productCodeTextBox.SelectionStart = 0;
            this.productCodeTextBox.Size = new System.Drawing.Size(167, 23);
            this.productCodeTextBox.TabIndex = 1;
            this.productCodeTextBox.UseSystemPasswordChar = false;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Depth = 0;
            this.productNameTextBox.Hint = "";
            this.productNameTextBox.Location = new System.Drawing.Point(172, 168);
            this.productNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.PasswordChar = '\0';
            this.productNameTextBox.SelectedText = "";
            this.productNameTextBox.SelectionLength = 0;
            this.productNameTextBox.SelectionStart = 0;
            this.productNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.productNameTextBox.TabIndex = 2;
            this.productNameTextBox.UseSystemPasswordChar = false;
            // 
            // productInitialAmountTextBox
            // 
            this.productInitialAmountTextBox.Depth = 0;
            this.productInitialAmountTextBox.Hint = "";
            this.productInitialAmountTextBox.Location = new System.Drawing.Point(172, 233);
            this.productInitialAmountTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.productInitialAmountTextBox.Name = "productInitialAmountTextBox";
            this.productInitialAmountTextBox.PasswordChar = '\0';
            this.productInitialAmountTextBox.SelectedText = "";
            this.productInitialAmountTextBox.SelectionLength = 0;
            this.productInitialAmountTextBox.SelectionStart = 0;
            this.productInitialAmountTextBox.Size = new System.Drawing.Size(167, 23);
            this.productInitialAmountTextBox.TabIndex = 3;
            this.productInitialAmountTextBox.UseSystemPasswordChar = false;
            // 
            // productHppPriceTextBox
            // 
            this.productHppPriceTextBox.Depth = 0;
            this.productHppPriceTextBox.Hint = "";
            this.productHppPriceTextBox.Location = new System.Drawing.Point(172, 291);
            this.productHppPriceTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.productHppPriceTextBox.Name = "productHppPriceTextBox";
            this.productHppPriceTextBox.PasswordChar = '\0';
            this.productHppPriceTextBox.SelectedText = "";
            this.productHppPriceTextBox.SelectionLength = 0;
            this.productHppPriceTextBox.SelectionStart = 0;
            this.productHppPriceTextBox.Size = new System.Drawing.Size(167, 23);
            this.productHppPriceTextBox.TabIndex = 4;
            this.productHppPriceTextBox.UseSystemPasswordChar = false;
            // 
            // productSellingPriceTextBox
            // 
            this.productSellingPriceTextBox.Depth = 0;
            this.productSellingPriceTextBox.Hint = "";
            this.productSellingPriceTextBox.Location = new System.Drawing.Point(172, 350);
            this.productSellingPriceTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.productSellingPriceTextBox.Name = "productSellingPriceTextBox";
            this.productSellingPriceTextBox.PasswordChar = '\0';
            this.productSellingPriceTextBox.SelectedText = "";
            this.productSellingPriceTextBox.SelectionLength = 0;
            this.productSellingPriceTextBox.SelectionStart = 0;
            this.productSellingPriceTextBox.Size = new System.Drawing.Size(167, 23);
            this.productSellingPriceTextBox.TabIndex = 5;
            this.productSellingPriceTextBox.UseSystemPasswordChar = false;
            // 
            // idProductLabel
            // 
            this.idProductLabel.AutoSize = true;
            this.idProductLabel.Depth = 0;
            this.idProductLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.idProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idProductLabel.Location = new System.Drawing.Point(13, 86);
            this.idProductLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.idProductLabel.Name = "idProductLabel";
            this.idProductLabel.Size = new System.Drawing.Size(23, 19);
            this.idProductLabel.TabIndex = 8;
            this.idProductLabel.Text = "ID";
            this.idProductLabel.Visible = false;
            // 
            // idProductValue
            // 
            this.idProductValue.AutoSize = true;
            this.idProductValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductValue.Location = new System.Drawing.Point(14, 119);
            this.idProductValue.Name = "idProductValue";
            this.idProductValue.Size = new System.Drawing.Size(66, 24);
            this.idProductValue.TabIndex = 9;
            this.idProductValue.Text = "label1";
            this.idProductValue.Visible = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 409);
            this.Controls.Add(this.idProductValue);
            this.Controls.Add(this.idProductLabel);
            this.Controls.Add(this.productSellingPriceTextBox);
            this.Controls.Add(this.productHppPriceTextBox);
            this.Controls.Add(this.productInitialAmountTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.cancelAddProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.hargaJualBarangTextBox);
            this.Controls.Add(this.hargaHPPBarangTextBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormProduct";
            this.Text = "Form Product";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel hargaHPPBarangTextBox;
        private MaterialSkin.Controls.MaterialLabel hargaJualBarangTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton addProductBtn;
        private MaterialSkin.Controls.MaterialRaisedButton cancelAddProductBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField productCodeTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField productNameTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField productInitialAmountTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField productHppPriceTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField productSellingPriceTextBox;
        private MaterialSkin.Controls.MaterialLabel idProductLabel;
        private System.Windows.Forms.Label idProductValue;
    }
}