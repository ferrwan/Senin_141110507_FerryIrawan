using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Latihan_2_1
{
    public partial class Form2_1 : MaterialForm
    {
        public Form2_1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            infoText.Text = deletedInfo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime birth = new DateTime(1997, 02, 07),
                startDate = new DateTime(2016, 01, 01);
            TimeSpan diff = new DateTime(2016, 12, 31) - startDate;

            for(var i=0;i<=diff.Days;i++)
            {
                var testDate = startDate.AddDays(i);
                switch(testDate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        DateTime weekday = new DateTime(testDate.Year, testDate.Month, testDate.Day);
                        monthCalendar1.AddBoldedDate(weekday);
                        break;
                }
            }

            listBox1.Items.Add("My Birthday: " + birth.Date);
            monthCalendar1.AddAnnuallyBoldedDate(birth);
            yearPicker.Format = DateTimePickerFormat.Custom;
            yearPicker.CustomFormat = "yyyy";
            yearPicker.ShowUpDown = true;
            string[] month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < month.Length; i++)
                monthsName.Items.Add(month[i]);
            monthsName.SelectedIndex = 0;
            yearPicker.TextChanged += new System.EventHandler(monthsName_SelectedItemChanged);

            addButton.Click += new System.EventHandler(addButton_Click);
            deleteButton.Click += new System.EventHandler(deleteButton_Click);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime specialDay = new DateTime(yearPicker.Value.Year, monthsName.SelectedIndex + 1, daysNumber.SelectedIndex + 1);
            int same = listBox1.FindStringExact(specialDay.ToShortDateString());
            if (same == ListBox.NoMatches)
            {
                listBox1.Items.Add(specialDay);
                infoText.Text = specialDay + " has been marked for a special day !";
                infoText.ForeColor = Color.Black;
                timer1.Start();
            }
            else
            {
                infoText.Text = "THAT DATE HAS BEEN ADDED BEFORE !!!";
                infoText.ForeColor = Color.Black;
                timer1.Start();
            }
            monthCalendar1.AddAnnuallyBoldedDate(specialDay);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(monthCalendar1.SelectionEnd);
            int idx = listBox1.FindStringExact(monthCalendar1.SelectionEnd.ToShortDateString());
            if(idx != ListBox.NoMatches)
                listBox1.Items.RemoveAt(idx);
            deletedInfo.Text = monthCalendar1.SelectionEnd.Day + "/" + monthCalendar1.SelectionEnd.Month + " has been marked as regular day.\n(Except Saturday and Sunday in 2016, they won't be remove)";
            deletedInfo.ForeColor = Color.Black;
            timer2.Start();
        }

        // Change Dates Range Every Time Month || Year Change
        private void monthsName_SelectedItemChanged(object sender, EventArgs e)
        {
            daysNumber.Items.Clear();
            int[] daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days = daysOfMonths[monthsName.SelectedIndex];
            days = (
                (yearPicker.Value.Year % 4 == 0 && yearPicker.Value.Year % 100 != 0) || yearPicker.Value.Year % 400 == 0 && monthsName.SelectedIndex == 1) ? 
                days + 1 : days;
            for (int i = 0; i < days; i++)
            {
                daysNumber.Items.Add(i + 1);
            }
            if (daysNumber.SelectedIndex + 1 > days)
                daysNumber.SelectedIndex = days - 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = (infoText.ForeColor.R >= 90) ? 15 : 5;
            infoText.ForeColor = Color.FromArgb(infoText.ForeColor.R + fadingSpeed, infoText.ForeColor.G + fadingSpeed, infoText.ForeColor.B + fadingSpeed);

            if(infoText.ForeColor.R >= this.BackColor.R)
            {
                timer1.Stop();
                infoText.ForeColor = this.BackColor;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = (deletedInfo.ForeColor.R >= 90) ? 15 : 5;
            deletedInfo.ForeColor = Color.FromArgb(deletedInfo.ForeColor.R + fadingSpeed, deletedInfo.ForeColor.G + fadingSpeed, deletedInfo.ForeColor.B + fadingSpeed);

            if (deletedInfo.ForeColor.R >= this.BackColor.R)
            {
                timer2.Stop();
                deletedInfo.ForeColor = this.BackColor;
            }
        }
    }
}
