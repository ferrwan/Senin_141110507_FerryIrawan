using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }
        private void Form3_1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionChanged += new System.EventHandler(richTextBox1_SelectionChanged);
            FontFamily[] fontList = FontFamily.Families;
            for (int i = 1; i <= 100; i++)
                fontSizeComboBox.Items.Add(i);
            foreach( FontFamily font in fontList)
            {
                fontFamilyComboBox.Items.Add(font.Name);
            }

            ArrayList colorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach(PropertyInfo c in propInfoList)
            {
                this.colorComboBox.Items.Add(c.Name);
            }

            fontSizeComboBox.SelectedIndex = fontSizeComboBox.FindString(this.Font.Size.ToString());
            fontFamilyComboBox.SelectedIndex = fontFamilyComboBox.FindString(this.Font.FontFamily.Name);
            colorComboBox.SelectedIndex = colorComboBox.FindString(this.ForeColor.Name);
        }
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                boldButton.BackColor = (richTextBox1.SelectionFont.Bold == true) ? System.Drawing.SystemColors.ButtonShadow : Color.Transparent;
                italicButton.BackColor = (richTextBox1.SelectionFont.Italic == true) ? System.Drawing.SystemColors.ButtonShadow : Color.Transparent;
                underlineButton.BackColor = (richTextBox1.SelectionFont.Underline == true) ? System.Drawing.SystemColors.ButtonShadow : Color.Transparent;
                int idx = fontFamilyComboBox.FindString(richTextBox1.SelectionFont.FontFamily.Name);
                fontFamilyComboBox.SelectedIndex = (idx >=0) ? idx : fontFamilyComboBox.FindString("Times New Roman");
                idx = colorComboBox.FindString(richTextBox1.SelectionColor.Name);
                colorComboBox.SelectedIndex = (idx >= 0) ? idx : colorComboBox.FindString(Color.Transparent.ToString());
            }
        }
        private void changeFontByButton(string type)
        {
            if(richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
                switch(type)
                {
                    case "bold":
                        if (richTextBox1.SelectionFont.Italic == true && richTextBox1.SelectionFont.Underline == true)
                            newFontStyle = FontStyle.Italic | FontStyle.Underline;
                        else if (richTextBox1.SelectionFont.Italic == true)
                            newFontStyle = FontStyle.Italic;
                        else if (richTextBox1.SelectionFont.Underline == true)
                            newFontStyle = FontStyle.Underline;

                        if (richTextBox1.SelectionFont.Bold != true)
                        {
                            newFontStyle |= FontStyle.Bold;
                            boldButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
                        }
                        else
                            boldButton.BackColor = System.Drawing.Color.Transparent;
                        break;

                    case "italic":
                        if (richTextBox1.SelectionFont.Bold == true && richTextBox1.SelectionFont.Underline == true)
                            newFontStyle = FontStyle.Bold | FontStyle.Underline;
                        else if (richTextBox1.SelectionFont.Bold == true)
                            newFontStyle = FontStyle.Bold;
                        else if (richTextBox1.SelectionFont.Underline == true)
                            newFontStyle = FontStyle.Underline;

                        if (richTextBox1.SelectionFont.Italic != true)
                        {
                            newFontStyle |= FontStyle.Italic;
                            italicButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
                        }
                        else
                            italicButton.BackColor = System.Drawing.Color.Transparent;
                        break;

                    case "underline":
                        if (richTextBox1.SelectionFont.Bold == true && richTextBox1.SelectionFont.Italic == true)
                            newFontStyle = FontStyle.Bold | FontStyle.Italic;
                        else if (richTextBox1.SelectionFont.Bold == true)
                            newFontStyle = FontStyle.Bold;
                        else if (richTextBox1.SelectionFont.Italic == true)
                            newFontStyle = FontStyle.Italic;

                        if (richTextBox1.SelectionFont.Underline != true)
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
        }
        private void boldButton_Click(object sender, EventArgs e)
        {
            changeFontByButton("bold");
        }
        private void italicButton_Click(object sender, EventArgs e)
        {
            changeFontByButton("italic");
        }
        private void underlineButton_Click(object sender, EventArgs e)
        {
            changeFontByButton("underline");
        }
        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle currentStyle = richTextBox1.SelectionFont.Style;
            richTextBox1.SelectionFont = new Font(fontFamilyComboBox.SelectedItem.ToString(), currentFont.Size, currentStyle);
        }
        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle currentStyle = richTextBox1.SelectionFont.Style;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSizeComboBox.SelectedIndex + 1, currentStyle);
        }
        private void fontSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (fontSizeComboBox.Text != "")
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                float size = Convert.ToSingle(fontSizeComboBox.Text);
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, size, currentStyle);
            }
        }
        private void colorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if(e.Index >= 0)
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
    }
}
