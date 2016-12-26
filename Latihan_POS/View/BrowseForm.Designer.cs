namespace Latihan_POS.View
{
    partial class BrowseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBrowse = new System.Windows.Forms.DataGridView();
            this.browseLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrowse
            // 
            this.dgvBrowse.AllowUserToAddRows = false;
            this.dgvBrowse.AllowUserToDeleteRows = false;
            this.dgvBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrowse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrowse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBrowse.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrowse.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrowse.Location = new System.Drawing.Point(27, 51);
            this.dgvBrowse.Name = "dgvBrowse";
            this.dgvBrowse.ReadOnly = true;
            this.dgvBrowse.Size = new System.Drawing.Size(631, 301);
            this.dgvBrowse.TabIndex = 0;
            this.dgvBrowse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrowseClick);
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Depth = 0;
            this.browseLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.browseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.browseLabel.Location = new System.Drawing.Point(23, 19);
            this.browseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(108, 19);
            this.browseLabel.TabIndex = 1;
            this.browseLabel.Text = "materialLabel1";
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 386);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.dgvBrowse);
            this.Name = "BrowseForm";
            this.Text = "BrowseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrowse;
        private MaterialSkin.Controls.MaterialLabel browseLabel;
    }
}