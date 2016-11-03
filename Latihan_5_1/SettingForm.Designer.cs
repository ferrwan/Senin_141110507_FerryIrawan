namespace Latihan_5_1
{
    partial class SettingForm
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.settingTreeView = new System.Windows.Forms.TreeView();
            this.themeBgPanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bgColorComboBox = new System.Windows.Forms.ComboBox();
            this.themeBgOkBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.themeBgCancelBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.themeBgApplyBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.themeBgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTreeView
            // 
            this.settingTreeView.Location = new System.Drawing.Point(12, 70);
            this.settingTreeView.Name = "settingTreeView";
            treeNode13.Name = "themeBgColor";
            treeNode13.Text = "Background Color";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Theme";
            this.settingTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.settingTreeView.ShowNodeToolTips = true;
            this.settingTreeView.Size = new System.Drawing.Size(158, 268);
            this.settingTreeView.TabIndex = 0;
            this.settingTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.settingTreeView_AfterSelect);
            // 
            // themeBgPanel
            // 
            this.themeBgPanel.Controls.Add(this.themeBgCancelBtn);
            this.themeBgPanel.Controls.Add(this.themeBgApplyBtn);
            this.themeBgPanel.Controls.Add(this.themeBgOkBtn);
            this.themeBgPanel.Controls.Add(this.bgColorComboBox);
            this.themeBgPanel.Controls.Add(this.materialLabel1);
            this.themeBgPanel.Location = new System.Drawing.Point(189, 70);
            this.themeBgPanel.Name = "themeBgPanel";
            this.themeBgPanel.Size = new System.Drawing.Size(437, 268);
            this.themeBgPanel.TabIndex = 2;
            this.themeBgPanel.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 17);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Background Color";
            // 
            // bgColorComboBox
            // 
            this.bgColorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bgColorComboBox.FormattingEnabled = true;
            this.bgColorComboBox.Location = new System.Drawing.Point(176, 18);
            this.bgColorComboBox.Name = "bgColorComboBox";
            this.bgColorComboBox.Size = new System.Drawing.Size(176, 21);
            this.bgColorComboBox.TabIndex = 1;
            this.bgColorComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.bgColorComboBox_DrawItem);
            this.bgColorComboBox.SelectedIndexChanged += new System.EventHandler(this.bgColorComboBox_SelectedIndexChanged);
            // 
            // themeBgOkBtn
            // 
            this.themeBgOkBtn.Depth = 0;
            this.themeBgOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeBgOkBtn.Location = new System.Drawing.Point(278, 224);
            this.themeBgOkBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBgOkBtn.Name = "themeBgOkBtn";
            this.themeBgOkBtn.Primary = true;
            this.themeBgOkBtn.Size = new System.Drawing.Size(74, 31);
            this.themeBgOkBtn.TabIndex = 2;
            this.themeBgOkBtn.Text = "Ok";
            this.themeBgOkBtn.UseVisualStyleBackColor = true;
            this.themeBgOkBtn.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // themeBgCancelBtn
            // 
            this.themeBgCancelBtn.Depth = 0;
            this.themeBgCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeBgCancelBtn.Location = new System.Drawing.Point(358, 224);
            this.themeBgCancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBgCancelBtn.Name = "themeBgCancelBtn";
            this.themeBgCancelBtn.Primary = true;
            this.themeBgCancelBtn.Size = new System.Drawing.Size(74, 31);
            this.themeBgCancelBtn.TabIndex = 2;
            this.themeBgCancelBtn.Text = "Close";
            this.themeBgCancelBtn.UseVisualStyleBackColor = true;
            this.themeBgCancelBtn.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // themeBgApplyBtn
            // 
            this.themeBgApplyBtn.Depth = 0;
            this.themeBgApplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeBgApplyBtn.Location = new System.Drawing.Point(198, 224);
            this.themeBgApplyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBgApplyBtn.Name = "themeBgApplyBtn";
            this.themeBgApplyBtn.Primary = true;
            this.themeBgApplyBtn.Size = new System.Drawing.Size(74, 31);
            this.themeBgApplyBtn.TabIndex = 2;
            this.themeBgApplyBtn.Text = "Apply";
            this.themeBgApplyBtn.UseVisualStyleBackColor = true;
            this.themeBgApplyBtn.Click += new System.EventHandler(this.themeBgApplyBtn_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 350);
            this.Controls.Add(this.themeBgPanel);
            this.Controls.Add(this.settingTreeView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.themeBgPanel.ResumeLayout(false);
            this.themeBgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView settingTreeView;
        private System.Windows.Forms.Panel themeBgPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox bgColorComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton themeBgCancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton themeBgOkBtn;
        private MaterialSkin.Controls.MaterialRaisedButton themeBgApplyBtn;
    }
}