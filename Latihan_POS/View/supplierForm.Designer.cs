namespace Latihan_POS.View
{
    partial class SupplierForm
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
            this.idSupplierLabel = new MaterialSkin.Controls.MaterialLabel();
            this.supplierPhoneNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.supplierZipCodeTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.supplierAddressTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.supplierNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.supplierEmailTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cancelAddSupplierBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addSupplierBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.hargaJualBarangTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.hargaHPPBarangTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.idSupplierValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idSupplierLabel
            // 
            this.idSupplierLabel.AutoSize = true;
            this.idSupplierLabel.Depth = 0;
            this.idSupplierLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.idSupplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idSupplierLabel.Location = new System.Drawing.Point(40, 86);
            this.idSupplierLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.idSupplierLabel.Name = "idSupplierLabel";
            this.idSupplierLabel.Size = new System.Drawing.Size(23, 19);
            this.idSupplierLabel.TabIndex = 36;
            this.idSupplierLabel.Text = "ID";
            this.idSupplierLabel.Visible = false;
            // 
            // supplierPhoneNumberTextBox
            // 
            this.supplierPhoneNumberTextBox.Depth = 0;
            this.supplierPhoneNumberTextBox.Hint = "";
            this.supplierPhoneNumberTextBox.Location = new System.Drawing.Point(224, 349);
            this.supplierPhoneNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierPhoneNumberTextBox.Name = "supplierPhoneNumberTextBox";
            this.supplierPhoneNumberTextBox.PasswordChar = '\0';
            this.supplierPhoneNumberTextBox.SelectedText = "";
            this.supplierPhoneNumberTextBox.SelectionLength = 0;
            this.supplierPhoneNumberTextBox.SelectionStart = 0;
            this.supplierPhoneNumberTextBox.Size = new System.Drawing.Size(167, 23);
            this.supplierPhoneNumberTextBox.TabIndex = 33;
            this.supplierPhoneNumberTextBox.UseSystemPasswordChar = false;
            // 
            // supplierZipCodeTextBox
            // 
            this.supplierZipCodeTextBox.Depth = 0;
            this.supplierZipCodeTextBox.Hint = "";
            this.supplierZipCodeTextBox.Location = new System.Drawing.Point(224, 290);
            this.supplierZipCodeTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierZipCodeTextBox.Name = "supplierZipCodeTextBox";
            this.supplierZipCodeTextBox.PasswordChar = '\0';
            this.supplierZipCodeTextBox.SelectedText = "";
            this.supplierZipCodeTextBox.SelectionLength = 0;
            this.supplierZipCodeTextBox.SelectionStart = 0;
            this.supplierZipCodeTextBox.Size = new System.Drawing.Size(167, 23);
            this.supplierZipCodeTextBox.TabIndex = 32;
            this.supplierZipCodeTextBox.UseSystemPasswordChar = false;
            // 
            // supplierAddressTextBox
            // 
            this.supplierAddressTextBox.Depth = 0;
            this.supplierAddressTextBox.Hint = "";
            this.supplierAddressTextBox.Location = new System.Drawing.Point(224, 232);
            this.supplierAddressTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierAddressTextBox.Name = "supplierAddressTextBox";
            this.supplierAddressTextBox.PasswordChar = '\0';
            this.supplierAddressTextBox.SelectedText = "";
            this.supplierAddressTextBox.SelectionLength = 0;
            this.supplierAddressTextBox.SelectionStart = 0;
            this.supplierAddressTextBox.Size = new System.Drawing.Size(167, 23);
            this.supplierAddressTextBox.TabIndex = 31;
            this.supplierAddressTextBox.UseSystemPasswordChar = false;
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Depth = 0;
            this.supplierNameTextBox.Hint = "";
            this.supplierNameTextBox.Location = new System.Drawing.Point(224, 167);
            this.supplierNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.PasswordChar = '\0';
            this.supplierNameTextBox.SelectedText = "";
            this.supplierNameTextBox.SelectionLength = 0;
            this.supplierNameTextBox.SelectionStart = 0;
            this.supplierNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.supplierNameTextBox.TabIndex = 30;
            this.supplierNameTextBox.UseSystemPasswordChar = false;
            // 
            // supplierEmailTextBox
            // 
            this.supplierEmailTextBox.Depth = 0;
            this.supplierEmailTextBox.Hint = "";
            this.supplierEmailTextBox.Location = new System.Drawing.Point(224, 108);
            this.supplierEmailTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierEmailTextBox.Name = "supplierEmailTextBox";
            this.supplierEmailTextBox.PasswordChar = '\0';
            this.supplierEmailTextBox.SelectedText = "";
            this.supplierEmailTextBox.SelectionLength = 0;
            this.supplierEmailTextBox.SelectionStart = 0;
            this.supplierEmailTextBox.Size = new System.Drawing.Size(167, 23);
            this.supplierEmailTextBox.TabIndex = 29;
            this.supplierEmailTextBox.UseSystemPasswordChar = false;
            // 
            // cancelAddSupplierBtn
            // 
            this.cancelAddSupplierBtn.Depth = 0;
            this.cancelAddSupplierBtn.Location = new System.Drawing.Point(439, 242);
            this.cancelAddSupplierBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelAddSupplierBtn.Name = "cancelAddSupplierBtn";
            this.cancelAddSupplierBtn.Primary = true;
            this.cancelAddSupplierBtn.Size = new System.Drawing.Size(113, 42);
            this.cancelAddSupplierBtn.TabIndex = 35;
            this.cancelAddSupplierBtn.Text = "Cancel";
            this.cancelAddSupplierBtn.UseVisualStyleBackColor = true;
            this.cancelAddSupplierBtn.Click += new System.EventHandler(this.cancelAddSupplierBtn_Click);
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Depth = 0;
            this.addSupplierBtn.Location = new System.Drawing.Point(439, 170);
            this.addSupplierBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Primary = true;
            this.addSupplierBtn.Size = new System.Drawing.Size(113, 42);
            this.addSupplierBtn.TabIndex = 34;
            this.addSupplierBtn.Text = "Create";
            this.addSupplierBtn.UseVisualStyleBackColor = true;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // hargaJualBarangTextBox
            // 
            this.hargaJualBarangTextBox.AutoSize = true;
            this.hargaJualBarangTextBox.Depth = 0;
            this.hargaJualBarangTextBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.hargaJualBarangTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hargaJualBarangTextBox.Location = new System.Drawing.Point(220, 327);
            this.hargaJualBarangTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hargaJualBarangTextBox.Name = "hargaJualBarangTextBox";
            this.hargaJualBarangTextBox.Size = new System.Drawing.Size(108, 19);
            this.hargaJualBarangTextBox.TabIndex = 24;
            this.hargaJualBarangTextBox.Text = "Phone Number";
            // 
            // hargaHPPBarangTextBox
            // 
            this.hargaHPPBarangTextBox.AutoSize = true;
            this.hargaHPPBarangTextBox.Depth = 0;
            this.hargaHPPBarangTextBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.hargaHPPBarangTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hargaHPPBarangTextBox.Location = new System.Drawing.Point(220, 268);
            this.hargaHPPBarangTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hargaHPPBarangTextBox.Name = "hargaHPPBarangTextBox";
            this.hargaHPPBarangTextBox.Size = new System.Drawing.Size(69, 19);
            this.hargaHPPBarangTextBox.TabIndex = 25;
            this.hargaHPPBarangTextBox.Text = "Zip Code";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(220, 209);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Address";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(220, 145);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(220, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Email";
            // 
            // idSupplierValue
            // 
            this.idSupplierValue.AutoSize = true;
            this.idSupplierValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSupplierValue.Location = new System.Drawing.Point(40, 122);
            this.idSupplierValue.Name = "idSupplierValue";
            this.idSupplierValue.Size = new System.Drawing.Size(66, 24);
            this.idSupplierValue.TabIndex = 37;
            this.idSupplierValue.Text = "label1";
            this.idSupplierValue.Visible = false;
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 407);
            this.Controls.Add(this.idSupplierValue);
            this.Controls.Add(this.idSupplierLabel);
            this.Controls.Add(this.supplierPhoneNumberTextBox);
            this.Controls.Add(this.supplierZipCodeTextBox);
            this.Controls.Add(this.supplierAddressTextBox);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.supplierEmailTextBox);
            this.Controls.Add(this.cancelAddSupplierBtn);
            this.Controls.Add(this.addSupplierBtn);
            this.Controls.Add(this.hargaJualBarangTextBox);
            this.Controls.Add(this.hargaHPPBarangTextBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel idSupplierLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField supplierPhoneNumberTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField supplierZipCodeTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField supplierAddressTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField supplierNameTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField supplierEmailTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton cancelAddSupplierBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addSupplierBtn;
        private MaterialSkin.Controls.MaterialLabel hargaJualBarangTextBox;
        private MaterialSkin.Controls.MaterialLabel hargaHPPBarangTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label idSupplierValue;
    }
}