using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.IO;

namespace Latihan_4_1
{
    public partial class Form4_1 : Form
    {
        bool noRepeatSelectionChange = false;
        int fontIdx;
        public Form4_1()
        {
            InitializeComponent();
        }
        private void Form4_1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontList = FontFamily.Families;
            for (int i = 1; i <= 100; i++)
                fontSizeComboBox.Items.Add(i);
            foreach (FontFamily font in fontList)
            {
                fontFamilyComboBox.Items.Add(font.Name);
            }

            ArrayList colorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.colorComboBox.Items.Add(c.Name);
            }
            fontSizeComboBox.SelectedIndex = fontSizeComboBox.FindString(this.Font.Size.ToString());
            fontFamilyComboBox.SelectedIndex = fontFamilyComboBox.FindString(this.Font.FontFamily.Name);
            colorComboBox.SelectedIndex = colorComboBox.FindString(this.ForeColor.Name);
        }
        private void getFontByChar(string type, string style)
        {
            int start = richTextBox1.SelectionStart,
                length = richTextBox1.SelectionLength;
            bool bold = false, italic = false, underline = false;
            noRepeatSelectionChange = true;
            if (type == "change-style")
            {
                if (richTextBox1.SelectionFont != null)
                {
                    bold = richTextBox1.SelectionFont.Bold ? true : false;
                    italic = richTextBox1.SelectionFont.Italic ? true : false;
                    underline = richTextBox1.SelectionFont.Underline ? true : false;
                }
                else
                    bold = italic = underline = false;
            }
            for (int i = start; i < start + length; i++)
            {
                richTextBox1.Select(i, 1);
                if (type == "rtb-select-change")
                {
                    bold = (richTextBox1.SelectionFont.Bold) ? true : false;
                    italic = (richTextBox1.SelectionFont.Italic) ? true : false;
                    underline = (richTextBox1.SelectionFont.Underline) ? true : false;
                }
                else if (type == "change-style")
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
                    if (!bold)
                        bold = (richTextBox1.SelectionFont.Bold) ? true : false;
                    if (!italic)
                        italic = (richTextBox1.SelectionFont.Italic) ? true : false;
                    if (!underline)
                        underline = (richTextBox1.SelectionFont.Underline) ? true : false;
                    switch (style)
                    {
                        case "bold":
                            if (italic)
                                newFontStyle = (underline) ? FontStyle.Italic | FontStyle.Underline : FontStyle.Italic;
                            else if (underline)
                                newFontStyle = FontStyle.Underline;
                            if (!bold)
                            {
                                newFontStyle |= FontStyle.Bold;
                                boldButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
                            }
                            else
                                boldButton.BackColor = System.Drawing.Color.Transparent;
                            break;
                        case "italic":
                            if (bold)
                                newFontStyle = (underline) ? FontStyle.Bold | FontStyle.Underline : FontStyle.Bold;
                            else if (underline)
                                newFontStyle = FontStyle.Underline;
                            if (!italic)
                            {
                                newFontStyle |= FontStyle.Italic;
                                italicButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
                            }
                            else
                                italicButton.BackColor = System.Drawing.Color.Transparent;
                            break;
                        case "underline":
                            if (bold)
                                newFontStyle = (italic) ? FontStyle.Bold | FontStyle.Italic : FontStyle.Bold;
                            else if (italic)
                                newFontStyle = FontStyle.Italic;
                            if (!underline)
                            {
                                newFontStyle |= FontStyle.Underline;
                                underlineButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
                            }
                            else
                                underlineButton.BackColor = System.Drawing.Color.Transparent;
                            break;
                    }
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
                else if (type == "change-font-size")
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                    float size = Convert.ToSingle(fontSizeComboBox.Text);
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, size, currentStyle);
                }
                else if (type == "change-font-family")
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                    richTextBox1.SelectionFont = new Font(fontFamilyComboBox.SelectedItem.ToString(), currentFont.Size, currentStyle);
                }
            }
            richTextBox1.Select(start, length);
            if (type == "rtb-select-change")
            {
                boldButton.BackColor = (bold) ? System.Drawing.SystemColors.ButtonShadow : Color.Transparent;
                italicButton.BackColor = (italic) ? System.Drawing.SystemColors.ButtonShadow : Color.Transparent;
                underlineButton.BackColor = (underline) ? System.Drawing.SystemColors.ButtonShadow : Color.Transparent;
                fontIdx = -1;
                if (richTextBox1.SelectionFont != null)
                {
                    fontIdx = fontFamilyComboBox.FindString(richTextBox1.SelectionFont.FontFamily.Name);
                }
                if (fontIdx >= 0)
                {
                    fontFamilyComboBox.SelectedIndex = fontIdx;
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    fontSizeComboBox.SelectedIndex = fontSizeComboBox.FindString(currentFont.Size.ToString());
                }
                int idx = colorComboBox.FindString(richTextBox1.SelectionColor.Name);
                colorComboBox.SelectedIndex = (idx >= 0) ? idx : colorComboBox.FindString(Color.Transparent.ToString());
            }
            noRepeatSelectionChange = false;
        }
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (!noRepeatSelectionChange)
                if (richTextBox1.SelectionLength > 0)
                    getFontByChar("rtb-select-change", "");
        }
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.B)
                    boldButton_Click(sender, e);
                else if (e.KeyCode == Keys.I)
                {
                    italicButton_Click(sender, e);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.U)
                    underlineButton_Click(sender, e);
            }
        }
        private void changeStyleByChar(string type)
        {
            if (!noRepeatSelectionChange)
                if (richTextBox1.SelectionLength > 0)
                    getFontByChar("change-style", type);
        }
        private void boldButton_Click(object sender, EventArgs e)
        {
            changeStyleByChar("bold");
        }
        private void italicButton_Click(object sender, EventArgs e)
        {
            changeStyleByChar("italic");
        }
        private void underlineButton_Click(object sender, EventArgs e)
        {
            changeStyleByChar("underline");
        }
        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFontByChar("change-font-family", "");
        }
        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFontByChar("change-font-size", "");
        }
        private void fontSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (fontSizeComboBox.Text != "")
                getFontByChar("change-font-size", "");
        }
        private void colorComboBox_DrawItem(object sender, DrawItemEventArgs e)
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
        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorComboBox.SelectedIndex >= 0)
            {
                Color c = Color.FromName(colorComboBox.Items[colorComboBox.SelectedIndex].ToString());
                richTextBox1.SelectionColor = c;
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4_1 form = new Form4_1();
            form.Show();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            try
            {
                openFile.DefaultExt = "*.rtf";
                openFile.Filter = "RTF Files | *.rtf";
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
                {
                    richTextBox1.LoadFile(openFile.FileName);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            try
            {
                saveDialog.DefaultExt = "*.rtf";
                saveDialog.Filter = "RTF Files (*.rtf*)|*.rtf*";
                saveDialog.Title = "Save";
                if(saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveDialog.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveDialog.FileName);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save your file?", "Save File ?", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else if (result == DialogResult.No)
            {
                
            }
            else
                e.Cancel = true;
        }
    }
}
