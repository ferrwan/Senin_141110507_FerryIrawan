namespace Latihan_POS
{
    partial class mainForm
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
            this.registerMenuBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.registerMenuPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabRegister = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listProductBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addNewProductBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listCustomerBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addNewCustomerBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listSupplierBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addNewSupplierBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backMenuBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.transactionMenuBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.posMenuPanel = new System.Windows.Forms.Panel();
            this.registerMenuPanel.SuspendLayout();
            this.materialTabRegister.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.posMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerMenuBtn
            // 
            this.registerMenuBtn.Depth = 0;
            this.registerMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMenuBtn.Location = new System.Drawing.Point(23, 20);
            this.registerMenuBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerMenuBtn.Name = "registerMenuBtn";
            this.registerMenuBtn.Primary = true;
            this.registerMenuBtn.Size = new System.Drawing.Size(159, 59);
            this.registerMenuBtn.TabIndex = 1;
            this.registerMenuBtn.Text = "Register";
            this.registerMenuBtn.UseVisualStyleBackColor = true;
            this.registerMenuBtn.Click += new System.EventHandler(this.registerMenuBtn_Click);
            // 
            // registerMenuPanel
            // 
            this.registerMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerMenuPanel.Controls.Add(this.materialTabSelector1);
            this.registerMenuPanel.Controls.Add(this.materialTabRegister);
            this.registerMenuPanel.Controls.Add(this.backMenuBtn);
            this.registerMenuPanel.Location = new System.Drawing.Point(1, 63);
            this.registerMenuPanel.Name = "registerMenuPanel";
            this.registerMenuPanel.Size = new System.Drawing.Size(676, 297);
            this.registerMenuPanel.TabIndex = 2;
            this.registerMenuPanel.Visible = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabRegister;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 34);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(676, 42);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabRegister
            // 
            this.materialTabRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabRegister.Controls.Add(this.tabPage1);
            this.materialTabRegister.Controls.Add(this.tabPage2);
            this.materialTabRegister.Controls.Add(this.tabPage3);
            this.materialTabRegister.Depth = 0;
            this.materialTabRegister.Location = new System.Drawing.Point(10, 70);
            this.materialTabRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabRegister.Multiline = true;
            this.materialTabRegister.Name = "materialTabRegister";
            this.materialTabRegister.SelectedIndex = 0;
            this.materialTabRegister.Size = new System.Drawing.Size(653, 146);
            this.materialTabRegister.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabRegister.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.listProductBtn);
            this.tabPage1.Controls.Add(this.addNewProductBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 120);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Supplier";
            // 
            // listProductBtn
            // 
            this.listProductBtn.Depth = 0;
            this.listProductBtn.Location = new System.Drawing.Point(196, 46);
            this.listProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.listProductBtn.Name = "listProductBtn";
            this.listProductBtn.Primary = true;
            this.listProductBtn.Size = new System.Drawing.Size(151, 37);
            this.listProductBtn.TabIndex = 0;
            this.listProductBtn.Text = "List Products";
            this.listProductBtn.UseVisualStyleBackColor = true;
            this.listProductBtn.Click += new System.EventHandler(this.listProductBtn_Click);
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.Depth = 0;
            this.addNewProductBtn.Location = new System.Drawing.Point(22, 46);
            this.addNewProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Primary = true;
            this.addNewProductBtn.Size = new System.Drawing.Size(151, 37);
            this.addNewProductBtn.TabIndex = 0;
            this.addNewProductBtn.Text = "Add New Product";
            this.addNewProductBtn.UseVisualStyleBackColor = true;
            this.addNewProductBtn.Click += new System.EventHandler(this.addNewProductBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.listCustomerBtn);
            this.tabPage2.Controls.Add(this.addNewCustomerBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 13);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Customer";
            // 
            // listCustomerBtn
            // 
            this.listCustomerBtn.Depth = 0;
            this.listCustomerBtn.Location = new System.Drawing.Point(192, 47);
            this.listCustomerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.listCustomerBtn.Name = "listCustomerBtn";
            this.listCustomerBtn.Primary = true;
            this.listCustomerBtn.Size = new System.Drawing.Size(151, 37);
            this.listCustomerBtn.TabIndex = 3;
            this.listCustomerBtn.Text = "List Customers";
            this.listCustomerBtn.UseVisualStyleBackColor = true;
            this.listCustomerBtn.Click += new System.EventHandler(this.listCustomerBtn_Click);
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Depth = 0;
            this.addNewCustomerBtn.Location = new System.Drawing.Point(23, 47);
            this.addNewCustomerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Primary = true;
            this.addNewCustomerBtn.Size = new System.Drawing.Size(151, 37);
            this.addNewCustomerBtn.TabIndex = 4;
            this.addNewCustomerBtn.Text = "Add New Customer";
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.listSupplierBtn);
            this.tabPage3.Controls.Add(this.addNewSupplierBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(645, 120);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Supplier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Product";
            // 
            // listSupplierBtn
            // 
            this.listSupplierBtn.Depth = 0;
            this.listSupplierBtn.Location = new System.Drawing.Point(198, 46);
            this.listSupplierBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.listSupplierBtn.Name = "listSupplierBtn";
            this.listSupplierBtn.Primary = true;
            this.listSupplierBtn.Size = new System.Drawing.Size(151, 37);
            this.listSupplierBtn.TabIndex = 3;
            this.listSupplierBtn.Text = "List Suppliers";
            this.listSupplierBtn.UseVisualStyleBackColor = true;
            this.listSupplierBtn.Click += new System.EventHandler(this.listSupplierBtn_Click);
            // 
            // addNewSupplierBtn
            // 
            this.addNewSupplierBtn.Depth = 0;
            this.addNewSupplierBtn.Location = new System.Drawing.Point(24, 46);
            this.addNewSupplierBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewSupplierBtn.Name = "addNewSupplierBtn";
            this.addNewSupplierBtn.Primary = true;
            this.addNewSupplierBtn.Size = new System.Drawing.Size(151, 37);
            this.addNewSupplierBtn.TabIndex = 4;
            this.addNewSupplierBtn.Text = "Add New Supplier";
            this.addNewSupplierBtn.UseVisualStyleBackColor = true;
            this.addNewSupplierBtn.Click += new System.EventHandler(this.addNewSupplierBtn_Click);
            // 
            // backMenuBtn
            // 
            this.backMenuBtn.AutoSize = true;
            this.backMenuBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backMenuBtn.Depth = 0;
            this.backMenuBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.backMenuBtn.Location = new System.Drawing.Point(-1, -1);
            this.backMenuBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backMenuBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backMenuBtn.Name = "backMenuBtn";
            this.backMenuBtn.Primary = false;
            this.backMenuBtn.Size = new System.Drawing.Size(58, 36);
            this.backMenuBtn.TabIndex = 2;
            this.backMenuBtn.Text = "< Back";
            this.backMenuBtn.UseVisualStyleBackColor = true;
            this.backMenuBtn.Click += new System.EventHandler(this.backMenuBtn_Click);
            // 
            // transactionMenuBtn
            // 
            this.transactionMenuBtn.Depth = 0;
            this.transactionMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionMenuBtn.Location = new System.Drawing.Point(213, 20);
            this.transactionMenuBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionMenuBtn.Name = "transactionMenuBtn";
            this.transactionMenuBtn.Primary = true;
            this.transactionMenuBtn.Size = new System.Drawing.Size(159, 59);
            this.transactionMenuBtn.TabIndex = 1;
            this.transactionMenuBtn.Text = "Transaction";
            this.transactionMenuBtn.UseVisualStyleBackColor = true;
            this.transactionMenuBtn.Click += new System.EventHandler(this.transactionMenuBtn_Click);
            // 
            // posMenuPanel
            // 
            this.posMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.posMenuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.posMenuPanel.Controls.Add(this.registerMenuBtn);
            this.posMenuPanel.Controls.Add(this.transactionMenuBtn);
            this.posMenuPanel.Location = new System.Drawing.Point(1, 63);
            this.posMenuPanel.Name = "posMenuPanel";
            this.posMenuPanel.Size = new System.Drawing.Size(676, 100);
            this.posMenuPanel.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 361);
            this.Controls.Add(this.posMenuPanel);
            this.Controls.Add(this.registerMenuPanel);
            this.Name = "mainForm";
            this.Text = "Latihan POS";
            this.registerMenuPanel.ResumeLayout(false);
            this.registerMenuPanel.PerformLayout();
            this.materialTabRegister.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.posMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton registerMenuBtn;
        private System.Windows.Forms.Panel registerMenuPanel;
        private MaterialSkin.Controls.MaterialRaisedButton listProductBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addNewProductBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton backMenuBtn;
        private MaterialSkin.Controls.MaterialTabControl materialTabRegister;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton listCustomerBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addNewCustomerBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton listSupplierBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addNewSupplierBtn;
        private MaterialSkin.Controls.MaterialRaisedButton transactionMenuBtn;
        private System.Windows.Forms.Panel posMenuPanel;
    }
}

