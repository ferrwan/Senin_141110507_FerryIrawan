using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Globalization;

namespace Latihan_5_1
{
    public partial class SettingForm : MaterialForm
    {
        Form5_1 form5;
        Boolean change;
        private Form5_1 Form5_1
        {
            get { return form5; }
            set { form5 = value; }
        }
        public SettingForm(Form5_1 parentForm)
        {
            InitializeComponent();
            form5 = parentForm;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.BlueGrey400, Primary.BlueGrey400, Accent.LightBlue400, TextShade.WHITE);

            ArrayList colorList = new ArrayList();
            var colorProperties = typeof(Color)
               .GetProperties(BindingFlags.Public | BindingFlags.Static)
               .Where(p => p.PropertyType == typeof(Color));
            string bgC = form5.BackColor.ToString();
            foreach (var colorProperty in colorProperties)
            {
                var c = (Color)colorProperty.GetValue(null, null);
                if (c.R == form5.BackColor.R
                        && c.G == form5.BackColor.G
                        && c.B == form5.BackColor.B)
                    bgC = c.Name;
                if(c.Name != "Transparent")
                    this.bgColorComboBox.Items.Add(c.Name);
            }
            bgColorComboBox.SelectedIndex = bgColorComboBox.FindString(bgC);
            change = false;
            themeBgCancelBtn.Text = "Close";
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
        }
        private void bgColorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5,
                                rect.Width - 10, rect.Height - 10);
            }
        }

        private void settingTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (settingTreeView.SelectedNode.Name == "themeBgColor")
            {
                this.themeBgPanel.Show();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Color c = Color.FromName(bgColorComboBox.Items[bgColorComboBox.SelectedIndex].ToString());
            form5.BackColor = c;
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (change)
            {
                DialogResult result = MessageBox.Show("Do you want to discard your changes?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Close();
            }
            else
                Close();
        }

        private void themeBgApplyBtn_Click(object sender, EventArgs e)
        {
            Color c = Color.FromName(bgColorComboBox.Items[bgColorComboBox.SelectedIndex].ToString());
            form5.BackColor = c;
            change = false;
            themeBgCancelBtn.Text = "Close";
        }

        private void bgColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            change = true;
            themeBgCancelBtn.Text = "Cancel";
        }
    }
}
