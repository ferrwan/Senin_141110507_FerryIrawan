using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Latihan_POS.DatabaseClass;
using Latihan_POS.View;

namespace Latihan_POS
{
    public partial class mainForm : MaterialForm
    {

        public mainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
        }

        private void registerMenuBtn_Click(object sender, EventArgs e)
        {
            posMenuPanel.Visible = false;
            registerMenuPanel.Visible = true;
        }

        private void backMenuBtn_Click(object sender, EventArgs e)
        {
            registerMenuPanel.Visible = false;
            posMenuPanel.Visible = true;
        }
        private void addNewProductBtn_Click(object sender, EventArgs e)
        {
            View.ProductForm productForm = new View.ProductForm();
            this.Hide();
            productForm.ShowDialog();
            this.Show();
        }
        private void listProductBtn_Click(object sender, EventArgs e)
        {
            View.ProductListForm productListForm = new View.ProductListForm();
            this.Hide();
            productListForm.ShowDialog();
            this.Show();
        }

        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            View.CustomerForm CustomerForm = new View.CustomerForm();
            this.Hide();
            CustomerForm.ShowDialog();
            this.Show();
        }

        private void listCustomerBtn_Click(object sender, EventArgs e)
        {
            View.CustomerListForm customerListForm = new CustomerListForm();
            this.Hide();
            customerListForm.ShowDialog();
            this.Show();
        }

        private void addNewSupplierBtn_Click(object sender, EventArgs e)
        {
            View.SupplierForm supplierForm = new View.SupplierForm();
            this.Hide();
            supplierForm.ShowDialog();
            this.Show();
        }

        private void listSupplierBtn_Click(object sender, EventArgs e)
        {
            View.SupplierListForm supplierListForm = new SupplierListForm();
            this.Hide();
            supplierListForm.ShowDialog();
            this.Show();
        }

        private void transactionMenuBtn_Click(object sender, EventArgs e)
        {
            View.MainTransactionForm mainTransactionForm = new MainTransactionForm();
            this.Hide();
            mainTransactionForm.ShowDialog();
            this.Show();
        }
    }
}
