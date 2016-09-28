using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        int nowYear = DateTime.Today.Year;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.vScrollBar1.Value.ToString();
            this.label2.Text = this.vScrollBar2.Value.ToString();
            this.minRange.Text = (nowYear - this.vScrollBar1.Value).ToString();
            this.maxRange.Text = (nowYear - this.vScrollBar2.Value).ToString();
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.changeMin);
            this.vScrollBar2.ValueChanged += new System.EventHandler(this.changeMax);
            this.dateTimePicker1.MinDate = new DateTime(nowYear - this.vScrollBar1.Value, 1, 1);
            this.dateTimePicker1.MaxDate = new DateTime(nowYear - this.vScrollBar2.Value, 12, 31);
        }
        private void changeMin(object sender, EventArgs e)
        {
            if(this.vScrollBar1.Value < this.vScrollBar2.Value)
            {
                this.vScrollBar2.Value = this.vScrollBar1.Value;
            }
            this.minRange.Text = (nowYear - this.vScrollBar1.Value).ToString();
            this.label1.Text = Convert.ToString(this.vScrollBar1.Value);
            this.dateTimePicker1.MinDate = new DateTime(nowYear - this.vScrollBar1.Value, 1, 1);
        }
        private void changeMax(object sender, EventArgs e)
        {
            if(this.vScrollBar2.Value > this.vScrollBar1.Value)
            {
                this.vScrollBar1.Value = this.vScrollBar2.Value;
            }
            this.maxRange.Text = (nowYear - this.vScrollBar2.Value).ToString();
            this.label2.Text = Convert.ToString(this.vScrollBar2.Value);
            this.dateTimePicker1.MaxDate = new DateTime(nowYear - this.vScrollBar2.Value, 12, 31);
        }
    }
}
