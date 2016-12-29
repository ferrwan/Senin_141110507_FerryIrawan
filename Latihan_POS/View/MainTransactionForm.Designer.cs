namespace Latihan_POS.View
{
    partial class MainTransactionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.transactionMenuTabController = new MaterialSkin.Controls.MaterialTabControl();
            this.listTransactionTab = new System.Windows.Forms.TabPage();
            this.selectedTransactionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dgvListSelectedTransaction = new System.Windows.Forms.DataGridView();
            this.dgvListTransaction = new System.Windows.Forms.DataGridView();
            this.saleRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.purchaseRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.purchaseTab = new System.Windows.Forms.TabPage();
            this.purchaseTotalPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseAddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.purchaseProductBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.supplierBrowseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.purchaseCodeBrowseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvPurchaseItems = new System.Windows.Forms.DataGridView();
            this.purchaseSubtotalPriceTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.purchaseQuantityTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.purchaseProductPriceTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.purchaseProductTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.supplierTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.purchaseCodeTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.saleTab = new System.Windows.Forms.TabPage();
            this.saleTotalPriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saleAddBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.purchaseProductBrowseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saleCustomerBrowseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saleCodeBrowseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.saleSubTotalTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saleQuantityTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saleProductPriceTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saleProductTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.customerTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saleCodeTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionMenuTabController.SuspendLayout();
            this.listTransactionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSelectedTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransaction)).BeginInit();
            this.purchaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).BeginInit();
            this.saleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.transactionMenuTabController;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 61);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(730, 52);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // transactionMenuTabController
            // 
            this.transactionMenuTabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionMenuTabController.Controls.Add(this.listTransactionTab);
            this.transactionMenuTabController.Controls.Add(this.purchaseTab);
            this.transactionMenuTabController.Controls.Add(this.saleTab);
            this.transactionMenuTabController.Depth = 0;
            this.transactionMenuTabController.Location = new System.Drawing.Point(12, 105);
            this.transactionMenuTabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionMenuTabController.Name = "transactionMenuTabController";
            this.transactionMenuTabController.SelectedIndex = 0;
            this.transactionMenuTabController.Size = new System.Drawing.Size(706, 447);
            this.transactionMenuTabController.TabIndex = 1;
            // 
            // listTransactionTab
            // 
            this.listTransactionTab.Controls.Add(this.selectedTransactionLabel);
            this.listTransactionTab.Controls.Add(this.dgvListSelectedTransaction);
            this.listTransactionTab.Controls.Add(this.dgvListTransaction);
            this.listTransactionTab.Controls.Add(this.saleRadioBtn);
            this.listTransactionTab.Controls.Add(this.purchaseRadioBtn);
            this.listTransactionTab.Location = new System.Drawing.Point(4, 22);
            this.listTransactionTab.Name = "listTransactionTab";
            this.listTransactionTab.Padding = new System.Windows.Forms.Padding(3);
            this.listTransactionTab.Size = new System.Drawing.Size(698, 421);
            this.listTransactionTab.TabIndex = 0;
            this.listTransactionTab.Text = "List Transaction";
            this.listTransactionTab.UseVisualStyleBackColor = true;
            // 
            // selectedTransactionLabel
            // 
            this.selectedTransactionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedTransactionLabel.AutoSize = true;
            this.selectedTransactionLabel.Depth = 0;
            this.selectedTransactionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.selectedTransactionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectedTransactionLabel.Location = new System.Drawing.Point(21, 232);
            this.selectedTransactionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectedTransactionLabel.Name = "selectedTransactionLabel";
            this.selectedTransactionLabel.Size = new System.Drawing.Size(120, 19);
            this.selectedTransactionLabel.TabIndex = 2;
            this.selectedTransactionLabel.Text = "No List Selected";
            // 
            // dgvListSelectedTransaction
            // 
            this.dgvListSelectedTransaction.AllowUserToAddRows = false;
            this.dgvListSelectedTransaction.AllowUserToDeleteRows = false;
            this.dgvListSelectedTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSelectedTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSelectedTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListSelectedTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSelectedTransaction.Location = new System.Drawing.Point(25, 254);
            this.dgvListSelectedTransaction.Name = "dgvListSelectedTransaction";
            this.dgvListSelectedTransaction.ReadOnly = true;
            this.dgvListSelectedTransaction.Size = new System.Drawing.Size(645, 161);
            this.dgvListSelectedTransaction.TabIndex = 1;
            // 
            // dgvListTransaction
            // 
            this.dgvListTransaction.AllowUserToAddRows = false;
            this.dgvListTransaction.AllowUserToDeleteRows = false;
            this.dgvListTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTransaction.Location = new System.Drawing.Point(25, 61);
            this.dgvListTransaction.Name = "dgvListTransaction";
            this.dgvListTransaction.ReadOnly = true;
            this.dgvListTransaction.Size = new System.Drawing.Size(645, 152);
            this.dgvListTransaction.TabIndex = 1;
            this.dgvListTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTransaction_CellContentClick);
            // 
            // saleRadioBtn
            // 
            this.saleRadioBtn.AutoSize = true;
            this.saleRadioBtn.Depth = 0;
            this.saleRadioBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.saleRadioBtn.Location = new System.Drawing.Point(172, 16);
            this.saleRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saleRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.saleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleRadioBtn.Name = "saleRadioBtn";
            this.saleRadioBtn.Ripple = true;
            this.saleRadioBtn.Size = new System.Drawing.Size(56, 30);
            this.saleRadioBtn.TabIndex = 0;
            this.saleRadioBtn.Text = "Sale";
            this.saleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // purchaseRadioBtn
            // 
            this.purchaseRadioBtn.AutoSize = true;
            this.purchaseRadioBtn.Checked = true;
            this.purchaseRadioBtn.Depth = 0;
            this.purchaseRadioBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.purchaseRadioBtn.Location = new System.Drawing.Point(25, 16);
            this.purchaseRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.purchaseRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.purchaseRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseRadioBtn.Name = "purchaseRadioBtn";
            this.purchaseRadioBtn.Ripple = true;
            this.purchaseRadioBtn.Size = new System.Drawing.Size(87, 30);
            this.purchaseRadioBtn.TabIndex = 0;
            this.purchaseRadioBtn.TabStop = true;
            this.purchaseRadioBtn.Text = "Purchase";
            this.purchaseRadioBtn.UseVisualStyleBackColor = true;
            this.purchaseRadioBtn.CheckedChanged += new System.EventHandler(this.purchaseRadioBtn_CheckedChanged);
            // 
            // purchaseTab
            // 
            this.purchaseTab.Controls.Add(this.purchaseTotalPriceLabel);
            this.purchaseTab.Controls.Add(this.label2);
            this.purchaseTab.Controls.Add(this.purchaseAddButton);
            this.purchaseTab.Controls.Add(this.purchaseProductBtn);
            this.purchaseTab.Controls.Add(this.supplierBrowseBtn);
            this.purchaseTab.Controls.Add(this.purchaseCodeBrowseBtn);
            this.purchaseTab.Controls.Add(this.dgvPurchaseItems);
            this.purchaseTab.Controls.Add(this.purchaseSubtotalPriceTextBox);
            this.purchaseTab.Controls.Add(this.purchaseQuantityTextbox);
            this.purchaseTab.Controls.Add(this.purchaseProductPriceTextbox);
            this.purchaseTab.Controls.Add(this.purchaseProductTextbox);
            this.purchaseTab.Controls.Add(this.supplierTextbox);
            this.purchaseTab.Controls.Add(this.purchaseCodeTextbox);
            this.purchaseTab.Controls.Add(this.materialLabel6);
            this.purchaseTab.Controls.Add(this.materialLabel5);
            this.purchaseTab.Controls.Add(this.materialLabel4);
            this.purchaseTab.Controls.Add(this.materialLabel3);
            this.purchaseTab.Controls.Add(this.materialLabel2);
            this.purchaseTab.Controls.Add(this.materialLabel1);
            this.purchaseTab.Location = new System.Drawing.Point(4, 22);
            this.purchaseTab.Name = "purchaseTab";
            this.purchaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.purchaseTab.Size = new System.Drawing.Size(698, 421);
            this.purchaseTab.TabIndex = 1;
            this.purchaseTab.Text = "Purchase";
            this.purchaseTab.UseVisualStyleBackColor = true;
            // 
            // purchaseTotalPriceLabel
            // 
            this.purchaseTotalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseTotalPriceLabel.AutoSize = true;
            this.purchaseTotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseTotalPriceLabel.Location = new System.Drawing.Point(438, 398);
            this.purchaseTotalPriceLabel.Name = "purchaseTotalPriceLabel";
            this.purchaseTotalPriceLabel.Size = new System.Drawing.Size(40, 18);
            this.purchaseTotalPriceLabel.TabIndex = 27;
            this.purchaseTotalPriceLabel.Text = "0.00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total Price";
            // 
            // purchaseAddButton
            // 
            this.purchaseAddButton.Depth = 0;
            this.purchaseAddButton.Location = new System.Drawing.Point(441, 151);
            this.purchaseAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseAddButton.Name = "purchaseAddButton";
            this.purchaseAddButton.Primary = true;
            this.purchaseAddButton.Size = new System.Drawing.Size(157, 79);
            this.purchaseAddButton.TabIndex = 25;
            this.purchaseAddButton.Text = "Add";
            this.purchaseAddButton.UseVisualStyleBackColor = true;
            this.purchaseAddButton.Click += new System.EventHandler(this.purchaseAddButton_Click);
            // 
            // purchaseProductBtn
            // 
            this.purchaseProductBtn.Depth = 0;
            this.purchaseProductBtn.Location = new System.Drawing.Point(441, 95);
            this.purchaseProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseProductBtn.Name = "purchaseProductBtn";
            this.purchaseProductBtn.Primary = true;
            this.purchaseProductBtn.Size = new System.Drawing.Size(157, 36);
            this.purchaseProductBtn.TabIndex = 7;
            this.purchaseProductBtn.Text = "Browse Product";
            this.purchaseProductBtn.UseVisualStyleBackColor = true;
            this.purchaseProductBtn.Click += new System.EventHandler(this.purchaseProductBtn_Click);
            // 
            // supplierBrowseBtn
            // 
            this.supplierBrowseBtn.Depth = 0;
            this.supplierBrowseBtn.Location = new System.Drawing.Point(441, 53);
            this.supplierBrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierBrowseBtn.Name = "supplierBrowseBtn";
            this.supplierBrowseBtn.Primary = true;
            this.supplierBrowseBtn.Size = new System.Drawing.Size(157, 36);
            this.supplierBrowseBtn.TabIndex = 7;
            this.supplierBrowseBtn.Text = "Browse Supplier";
            this.supplierBrowseBtn.UseVisualStyleBackColor = true;
            this.supplierBrowseBtn.Click += new System.EventHandler(this.supplierBrowseBtn_Click);
            // 
            // purchaseCodeBrowseBtn
            // 
            this.purchaseCodeBrowseBtn.Depth = 0;
            this.purchaseCodeBrowseBtn.Location = new System.Drawing.Point(441, 11);
            this.purchaseCodeBrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseCodeBrowseBtn.Name = "purchaseCodeBrowseBtn";
            this.purchaseCodeBrowseBtn.Primary = true;
            this.purchaseCodeBrowseBtn.Size = new System.Drawing.Size(157, 36);
            this.purchaseCodeBrowseBtn.TabIndex = 7;
            this.purchaseCodeBrowseBtn.Text = "Browse Purchase Code";
            this.purchaseCodeBrowseBtn.UseVisualStyleBackColor = true;
            this.purchaseCodeBrowseBtn.Click += new System.EventHandler(this.purchaseCodeBrowseBtn_Click);
            // 
            // dgvPurchaseItems
            // 
            this.dgvPurchaseItems.AllowUserToAddRows = false;
            this.dgvPurchaseItems.AllowUserToDeleteRows = false;
            this.dgvPurchaseItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItems.Location = new System.Drawing.Point(6, 236);
            this.dgvPurchaseItems.Name = "dgvPurchaseItems";
            this.dgvPurchaseItems.ReadOnly = true;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.dgvPurchaseItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseItems.Size = new System.Drawing.Size(686, 156);
            this.dgvPurchaseItems.TabIndex = 6;
            // 
            // purchaseSubtotalPriceTextBox
            // 
            this.purchaseSubtotalPriceTextBox.AccessibleDescription = "";
            this.purchaseSubtotalPriceTextBox.Depth = 0;
            this.purchaseSubtotalPriceTextBox.Enabled = false;
            this.purchaseSubtotalPriceTextBox.Hint = "";
            this.purchaseSubtotalPriceTextBox.Location = new System.Drawing.Point(186, 207);
            this.purchaseSubtotalPriceTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseSubtotalPriceTextBox.Name = "purchaseSubtotalPriceTextBox";
            this.purchaseSubtotalPriceTextBox.PasswordChar = '\0';
            this.purchaseSubtotalPriceTextBox.SelectedText = "";
            this.purchaseSubtotalPriceTextBox.SelectionLength = 0;
            this.purchaseSubtotalPriceTextBox.SelectionStart = 0;
            this.purchaseSubtotalPriceTextBox.Size = new System.Drawing.Size(236, 23);
            this.purchaseSubtotalPriceTextBox.TabIndex = 5;
            this.purchaseSubtotalPriceTextBox.Text = "0.00";
            this.purchaseSubtotalPriceTextBox.UseSystemPasswordChar = false;
            // 
            // purchaseQuantityTextbox
            // 
            this.purchaseQuantityTextbox.Depth = 0;
            this.purchaseQuantityTextbox.Hint = "";
            this.purchaseQuantityTextbox.Location = new System.Drawing.Point(186, 171);
            this.purchaseQuantityTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseQuantityTextbox.Name = "purchaseQuantityTextbox";
            this.purchaseQuantityTextbox.PasswordChar = '\0';
            this.purchaseQuantityTextbox.SelectedText = "";
            this.purchaseQuantityTextbox.SelectionLength = 0;
            this.purchaseQuantityTextbox.SelectionStart = 0;
            this.purchaseQuantityTextbox.Size = new System.Drawing.Size(236, 23);
            this.purchaseQuantityTextbox.TabIndex = 5;
            this.purchaseQuantityTextbox.Text = "0";
            this.purchaseQuantityTextbox.UseSystemPasswordChar = false;
            this.purchaseQuantityTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchaseQuantityTextbox_KeyPress);
            this.purchaseQuantityTextbox.TextChanged += new System.EventHandler(this.purchaseQuantityTextBox_TextChanged);
            // 
            // purchaseProductPriceTextbox
            // 
            this.purchaseProductPriceTextbox.Depth = 0;
            this.purchaseProductPriceTextbox.Hint = "";
            this.purchaseProductPriceTextbox.Location = new System.Drawing.Point(186, 136);
            this.purchaseProductPriceTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseProductPriceTextbox.Name = "purchaseProductPriceTextbox";
            this.purchaseProductPriceTextbox.PasswordChar = '\0';
            this.purchaseProductPriceTextbox.SelectedText = "";
            this.purchaseProductPriceTextbox.SelectionLength = 0;
            this.purchaseProductPriceTextbox.SelectionStart = 0;
            this.purchaseProductPriceTextbox.Size = new System.Drawing.Size(236, 23);
            this.purchaseProductPriceTextbox.TabIndex = 5;
            this.purchaseProductPriceTextbox.UseSystemPasswordChar = false;
            this.purchaseProductPriceTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchaseProductPriceTextbox_KeyPress);
            this.purchaseProductPriceTextbox.TextChanged += new System.EventHandler(this.purchaseQuantityTextBox_TextChanged);
            // 
            // purchaseProductTextbox
            // 
            this.purchaseProductTextbox.Depth = 0;
            this.purchaseProductTextbox.Enabled = false;
            this.purchaseProductTextbox.Hint = "";
            this.purchaseProductTextbox.Location = new System.Drawing.Point(186, 98);
            this.purchaseProductTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseProductTextbox.Name = "purchaseProductTextbox";
            this.purchaseProductTextbox.PasswordChar = '\0';
            this.purchaseProductTextbox.SelectedText = "";
            this.purchaseProductTextbox.SelectionLength = 0;
            this.purchaseProductTextbox.SelectionStart = 0;
            this.purchaseProductTextbox.Size = new System.Drawing.Size(236, 23);
            this.purchaseProductTextbox.TabIndex = 5;
            this.purchaseProductTextbox.Text = "Click browse to select a product";
            this.purchaseProductTextbox.UseSystemPasswordChar = false;
            // 
            // supplierTextbox
            // 
            this.supplierTextbox.Depth = 0;
            this.supplierTextbox.Enabled = false;
            this.supplierTextbox.Hint = "";
            this.supplierTextbox.Location = new System.Drawing.Point(186, 57);
            this.supplierTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supplierTextbox.Name = "supplierTextbox";
            this.supplierTextbox.PasswordChar = '\0';
            this.supplierTextbox.SelectedText = "";
            this.supplierTextbox.SelectionLength = 0;
            this.supplierTextbox.SelectionStart = 0;
            this.supplierTextbox.Size = new System.Drawing.Size(236, 23);
            this.supplierTextbox.TabIndex = 5;
            this.supplierTextbox.Text = "Click browse to select a supplier";
            this.supplierTextbox.UseSystemPasswordChar = false;
            // 
            // purchaseCodeTextbox
            // 
            this.purchaseCodeTextbox.Depth = 0;
            this.purchaseCodeTextbox.Hint = "";
            this.purchaseCodeTextbox.Location = new System.Drawing.Point(186, 19);
            this.purchaseCodeTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseCodeTextbox.Name = "purchaseCodeTextbox";
            this.purchaseCodeTextbox.PasswordChar = '\0';
            this.purchaseCodeTextbox.SelectedText = "";
            this.purchaseCodeTextbox.SelectionLength = 0;
            this.purchaseCodeTextbox.SelectionStart = 0;
            this.purchaseCodeTextbox.Size = new System.Drawing.Size(236, 23);
            this.purchaseCodeTextbox.TabIndex = 5;
            this.purchaseCodeTextbox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(67, 211);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(103, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Subtotal Price";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(106, 175);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Quantity";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(71, 137);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(99, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Product Price";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(109, 102);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Product";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(107, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Supplier";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(126, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Code";
            // 
            // saleTab
            // 
            this.saleTab.Controls.Add(this.saleTotalPriceLabel);
            this.saleTab.Controls.Add(this.label1);
            this.saleTab.Controls.Add(this.saleAddBtn);
            this.saleTab.Controls.Add(this.purchaseProductBrowseBtn);
            this.saleTab.Controls.Add(this.saleCustomerBrowseBtn);
            this.saleTab.Controls.Add(this.saleCodeBrowseBtn);
            this.saleTab.Controls.Add(this.dgvSaleItems);
            this.saleTab.Controls.Add(this.saleSubTotalTextBox);
            this.saleTab.Controls.Add(this.saleQuantityTextbox);
            this.saleTab.Controls.Add(this.saleProductPriceTextbox);
            this.saleTab.Controls.Add(this.saleProductTextbox);
            this.saleTab.Controls.Add(this.customerTextbox);
            this.saleTab.Controls.Add(this.saleCodeTextbox);
            this.saleTab.Controls.Add(this.materialLabel7);
            this.saleTab.Controls.Add(this.materialLabel8);
            this.saleTab.Controls.Add(this.materialLabel9);
            this.saleTab.Controls.Add(this.materialLabel10);
            this.saleTab.Controls.Add(this.materialLabel11);
            this.saleTab.Controls.Add(this.materialLabel12);
            this.saleTab.Location = new System.Drawing.Point(4, 22);
            this.saleTab.Name = "saleTab";
            this.saleTab.Size = new System.Drawing.Size(698, 421);
            this.saleTab.TabIndex = 2;
            this.saleTab.Text = "Sale";
            this.saleTab.UseVisualStyleBackColor = true;
            // 
            // saleTotalPriceLabel
            // 
            this.saleTotalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleTotalPriceLabel.AutoSize = true;
            this.saleTotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTotalPriceLabel.Location = new System.Drawing.Point(453, 394);
            this.saleTotalPriceLabel.Name = "saleTotalPriceLabel";
            this.saleTotalPriceLabel.Size = new System.Drawing.Size(40, 18);
            this.saleTotalPriceLabel.TabIndex = 26;
            this.saleTotalPriceLabel.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Price";
            // 
            // saleAddBtn
            // 
            this.saleAddBtn.Depth = 0;
            this.saleAddBtn.Location = new System.Drawing.Point(456, 145);
            this.saleAddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleAddBtn.Name = "saleAddBtn";
            this.saleAddBtn.Primary = true;
            this.saleAddBtn.Size = new System.Drawing.Size(157, 77);
            this.saleAddBtn.TabIndex = 24;
            this.saleAddBtn.Text = "Add";
            this.saleAddBtn.UseVisualStyleBackColor = true;
            this.saleAddBtn.Click += new System.EventHandler(this.saleAddBtn_Click);
            // 
            // purchaseProductBrowseBtn
            // 
            this.purchaseProductBrowseBtn.Depth = 0;
            this.purchaseProductBrowseBtn.Location = new System.Drawing.Point(456, 93);
            this.purchaseProductBrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.purchaseProductBrowseBtn.Name = "purchaseProductBrowseBtn";
            this.purchaseProductBrowseBtn.Primary = true;
            this.purchaseProductBrowseBtn.Size = new System.Drawing.Size(157, 37);
            this.purchaseProductBrowseBtn.TabIndex = 21;
            this.purchaseProductBrowseBtn.Text = "Browse Product";
            this.purchaseProductBrowseBtn.UseVisualStyleBackColor = true;
            this.purchaseProductBrowseBtn.Click += new System.EventHandler(this.saleProductBrowseBtn_Click);
            // 
            // saleCustomerBrowseBtn
            // 
            this.saleCustomerBrowseBtn.Depth = 0;
            this.saleCustomerBrowseBtn.Location = new System.Drawing.Point(456, 51);
            this.saleCustomerBrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleCustomerBrowseBtn.Name = "saleCustomerBrowseBtn";
            this.saleCustomerBrowseBtn.Primary = true;
            this.saleCustomerBrowseBtn.Size = new System.Drawing.Size(157, 36);
            this.saleCustomerBrowseBtn.TabIndex = 22;
            this.saleCustomerBrowseBtn.Text = "Browse Customer";
            this.saleCustomerBrowseBtn.UseVisualStyleBackColor = true;
            this.saleCustomerBrowseBtn.Click += new System.EventHandler(this.customerBrowseBtn_Click);
            // 
            // saleCodeBrowseBtn
            // 
            this.saleCodeBrowseBtn.Depth = 0;
            this.saleCodeBrowseBtn.Location = new System.Drawing.Point(456, 9);
            this.saleCodeBrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleCodeBrowseBtn.Name = "saleCodeBrowseBtn";
            this.saleCodeBrowseBtn.Primary = true;
            this.saleCodeBrowseBtn.Size = new System.Drawing.Size(157, 37);
            this.saleCodeBrowseBtn.TabIndex = 23;
            this.saleCodeBrowseBtn.Text = "Browse Sale Code";
            this.saleCodeBrowseBtn.UseVisualStyleBackColor = true;
            this.saleCodeBrowseBtn.Click += new System.EventHandler(this.saleCodeBrowseBtn_Click);
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            this.dgvSaleItems.AllowUserToDeleteRows = false;
            this.dgvSaleItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Location = new System.Drawing.Point(6, 236);
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.ReadOnly = true;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.dgvSaleItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleItems.Size = new System.Drawing.Size(686, 155);
            this.dgvSaleItems.TabIndex = 20;
            // 
            // saleSubTotalTextBox
            // 
            this.saleSubTotalTextBox.AccessibleDescription = "";
            this.saleSubTotalTextBox.Depth = 0;
            this.saleSubTotalTextBox.Enabled = false;
            this.saleSubTotalTextBox.Hint = "";
            this.saleSubTotalTextBox.Location = new System.Drawing.Point(194, 201);
            this.saleSubTotalTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleSubTotalTextBox.Name = "saleSubTotalTextBox";
            this.saleSubTotalTextBox.PasswordChar = '\0';
            this.saleSubTotalTextBox.SelectedText = "";
            this.saleSubTotalTextBox.SelectionLength = 0;
            this.saleSubTotalTextBox.SelectionStart = 0;
            this.saleSubTotalTextBox.Size = new System.Drawing.Size(240, 23);
            this.saleSubTotalTextBox.TabIndex = 14;
            this.saleSubTotalTextBox.Text = "0.00";
            this.saleSubTotalTextBox.UseSystemPasswordChar = false;
            // 
            // saleQuantityTextbox
            // 
            this.saleQuantityTextbox.Depth = 0;
            this.saleQuantityTextbox.Hint = "";
            this.saleQuantityTextbox.Location = new System.Drawing.Point(194, 167);
            this.saleQuantityTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleQuantityTextbox.Name = "saleQuantityTextbox";
            this.saleQuantityTextbox.PasswordChar = '\0';
            this.saleQuantityTextbox.SelectedText = "";
            this.saleQuantityTextbox.SelectionLength = 0;
            this.saleQuantityTextbox.SelectionStart = 0;
            this.saleQuantityTextbox.Size = new System.Drawing.Size(240, 23);
            this.saleQuantityTextbox.TabIndex = 15;
            this.saleQuantityTextbox.Text = "0";
            this.saleQuantityTextbox.UseSystemPasswordChar = false;
            this.saleQuantityTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchaseQuantityTextbox_KeyPress);
            this.saleQuantityTextbox.TextChanged += new System.EventHandler(this.saleQuantityTextbox_TextChanged);
            // 
            // saleProductPriceTextbox
            // 
            this.saleProductPriceTextbox.Depth = 0;
            this.saleProductPriceTextbox.Hint = "";
            this.saleProductPriceTextbox.Location = new System.Drawing.Point(194, 132);
            this.saleProductPriceTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleProductPriceTextbox.Name = "saleProductPriceTextbox";
            this.saleProductPriceTextbox.PasswordChar = '\0';
            this.saleProductPriceTextbox.SelectedText = "";
            this.saleProductPriceTextbox.SelectionLength = 0;
            this.saleProductPriceTextbox.SelectionStart = 0;
            this.saleProductPriceTextbox.Size = new System.Drawing.Size(240, 23);
            this.saleProductPriceTextbox.TabIndex = 16;
            this.saleProductPriceTextbox.UseSystemPasswordChar = false;
            this.saleProductPriceTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchaseProductPriceTextbox_KeyPress);
            this.saleProductPriceTextbox.TextChanged += new System.EventHandler(this.saleQuantityTextbox_TextChanged);
            // 
            // saleProductTextbox
            // 
            this.saleProductTextbox.Depth = 0;
            this.saleProductTextbox.Enabled = false;
            this.saleProductTextbox.Hint = "";
            this.saleProductTextbox.Location = new System.Drawing.Point(194, 100);
            this.saleProductTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleProductTextbox.Name = "saleProductTextbox";
            this.saleProductTextbox.PasswordChar = '\0';
            this.saleProductTextbox.SelectedText = "";
            this.saleProductTextbox.SelectionLength = 0;
            this.saleProductTextbox.SelectionStart = 0;
            this.saleProductTextbox.Size = new System.Drawing.Size(240, 23);
            this.saleProductTextbox.TabIndex = 17;
            this.saleProductTextbox.Text = "Click browse to select a product";
            this.saleProductTextbox.UseSystemPasswordChar = false;
            // 
            // customerTextbox
            // 
            this.customerTextbox.Depth = 0;
            this.customerTextbox.Enabled = false;
            this.customerTextbox.Hint = "";
            this.customerTextbox.Location = new System.Drawing.Point(194, 57);
            this.customerTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerTextbox.Name = "customerTextbox";
            this.customerTextbox.PasswordChar = '\0';
            this.customerTextbox.SelectedText = "";
            this.customerTextbox.SelectionLength = 0;
            this.customerTextbox.SelectionStart = 0;
            this.customerTextbox.Size = new System.Drawing.Size(240, 23);
            this.customerTextbox.TabIndex = 18;
            this.customerTextbox.Text = "Click browse to select a customer";
            this.customerTextbox.UseSystemPasswordChar = false;
            // 
            // saleCodeTextbox
            // 
            this.saleCodeTextbox.Depth = 0;
            this.saleCodeTextbox.Hint = "";
            this.saleCodeTextbox.Location = new System.Drawing.Point(194, 17);
            this.saleCodeTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saleCodeTextbox.Name = "saleCodeTextbox";
            this.saleCodeTextbox.PasswordChar = '\0';
            this.saleCodeTextbox.SelectedText = "";
            this.saleCodeTextbox.SelectionLength = 0;
            this.saleCodeTextbox.SelectionStart = 0;
            this.saleCodeTextbox.Size = new System.Drawing.Size(240, 23);
            this.saleCodeTextbox.TabIndex = 19;
            this.saleCodeTextbox.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(75, 205);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(103, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Subtotal Price";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(114, 171);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 19);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "Quantity";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(79, 133);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(99, 19);
            this.materialLabel9.TabIndex = 10;
            this.materialLabel9.Text = "Product Price";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(117, 98);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(61, 19);
            this.materialLabel10.TabIndex = 11;
            this.materialLabel10.Text = "Product";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(103, 57);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(75, 19);
            this.materialLabel11.TabIndex = 12;
            this.materialLabel11.Text = "Customer";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(134, 17);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(44, 19);
            this.materialLabel12.TabIndex = 13;
            this.materialLabel12.Text = "Code";
            // 
            // MainTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 564);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.transactionMenuTabController);
            this.Name = "MainTransactionForm";
            this.Text = "Transaction Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainTransactionForm_Load);
            this.transactionMenuTabController.ResumeLayout(false);
            this.listTransactionTab.ResumeLayout(false);
            this.listTransactionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSelectedTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransaction)).EndInit();
            this.purchaseTab.ResumeLayout(false);
            this.purchaseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).EndInit();
            this.saleTab.ResumeLayout(false);
            this.saleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl transactionMenuTabController;
        private System.Windows.Forms.TabPage listTransactionTab;
        private System.Windows.Forms.TabPage purchaseTab;
        private System.Windows.Forms.TabPage saleTab;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField purchaseCodeTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField purchaseSubtotalPriceTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField purchaseQuantityTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField purchaseProductPriceTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField purchaseProductTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField supplierTextbox;
        private System.Windows.Forms.DataGridView dgvPurchaseItems;
        private MaterialSkin.Controls.MaterialRaisedButton purchaseProductBtn;
        private MaterialSkin.Controls.MaterialRaisedButton supplierBrowseBtn;
        private MaterialSkin.Controls.MaterialRaisedButton purchaseCodeBrowseBtn;
        private MaterialSkin.Controls.MaterialRaisedButton purchaseProductBrowseBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saleCustomerBrowseBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saleCodeBrowseBtn;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private MaterialSkin.Controls.MaterialSingleLineTextField saleSubTotalTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField saleQuantityTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField saleProductPriceTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField saleProductTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField customerTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField saleCodeTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialRaisedButton saleAddBtn;
        private MaterialSkin.Controls.MaterialRaisedButton purchaseAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saleTotalPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label purchaseTotalPriceLabel;
        private MaterialSkin.Controls.MaterialRadioButton saleRadioBtn;
        private MaterialSkin.Controls.MaterialRadioButton purchaseRadioBtn;
        private System.Windows.Forms.DataGridView dgvListSelectedTransaction;
        private System.Windows.Forms.DataGridView dgvListTransaction;
        private MaterialSkin.Controls.MaterialLabel selectedTransactionLabel;
    }
}