namespace volleyball_problem
{
    partial class Form1
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
            this.BtnHitung = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHitung
            // 
            this.BtnHitung.Depth = 0;
            this.BtnHitung.Location = new System.Drawing.Point(254, 182);
            this.BtnHitung.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Primary = true;
            this.BtnHitung.Size = new System.Drawing.Size(121, 34);
            this.BtnHitung.TabIndex = 1;
            this.BtnHitung.Text = "Count";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // Txt1
            // 
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.Location = new System.Drawing.Point(83, 139);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(192, 26);
            this.Txt1.TabIndex = 2;
            this.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            this.Txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // Txt2
            // 
            this.Txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt2.Location = new System.Drawing.Point(342, 139);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(192, 26);
            this.Txt2.TabIndex = 2;
            this.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt2.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            this.Txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(222, 239);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(182, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "The Different Sequences :";
            // 
            // TxtHasil
            // 
            this.TxtHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHasil.Location = new System.Drawing.Point(109, 276);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.Size = new System.Drawing.Size(425, 50);
            this.TxtHasil.TabIndex = 4;
            this.TxtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(168, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(427, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.BtnHitung);
            this.Name = "Form1";
            this.Text = "Volleyball Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BtnHitung;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

