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

namespace volleyball_problem
{
    public partial class Form1 : MaterialForm
    {
        long[] arr = new long[55];
        const long modulo = 1000000007;
        public long InverseEuler(long a)
        {
            long x = 1, z = modulo - 2;
            while (z > 0)
            {
                if (z % 2 == 1)
                    x = (x * a) % modulo;
                a = (a * a) % modulo;
                z /= 2;
            }
            return x;
        }
        public long modPow(long a, long exp)
        {
            long res = 1;
            while (exp > 0)
            {
                if (exp % 2 == 1)
                    res = (res * a) % modulo;
                a = (a * a) % modulo;
                exp >>= 1;
            }
            return res;
        }
        public long count(long a, long b)
        {
            if (a >= 25 || b >= 25)
            {
                arr[0] = arr[1] = 1;
                for (long i = 2; i <= 50; i++)
                {
                    arr[i] = ((long)i * arr[i - 1]) % modulo;
                }
                long min = Math.Min(a, b), max = Math.Max(a, b);
                long n = Math.Min(a + b - 1, 47), r = Math.Min(max - 1, 24);
                long res = (arr[n] * ((InverseEuler(arr[r]) * InverseEuler(arr[n - r])) % modulo)) % modulo;
                if ((a == 25 && b < 24) || (a < 24 && b == 25))
                    return res;
                else if (Math.Abs(a - b) != 2)
                    return 0;
                else
                    return (res * modPow(2, max - 25)) % modulo;
            }
            return 0;
        }
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            this.BtnHitung.Enabled = false;
            this.TxtHasil.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Txt1;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a = Int64.Parse(Txt1.Text), b = Int64.Parse(Txt2.Text);
            this.TxtHasil.Text = count(a, b).ToString();
        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {
            if (Txt1.TextLength > 0 && Txt2.TextLength > 0)
                BtnHitung.Enabled = true;
            else
                BtnHitung.Enabled = false;
        }
    }
}
