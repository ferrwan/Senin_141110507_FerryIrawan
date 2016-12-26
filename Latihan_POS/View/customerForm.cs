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
using Latihan_POS.DatabaseClass;

namespace Latihan_POS.View
{
    public partial class CustomerForm : MaterialForm
    {
        private string sqlAction = "post";
        public CustomerForm(Dictionary<string, string> data = null, string action = null)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            if (data != null && action == "Edit")
            {
                idCustomerLabel.Visible = idCustomerValue.Visible = true;
                idCustomerValue.Text = data["id"];
                customerEmailTextBox.Text = data["email"];
                customerNameTextBox.Text = data["name"];
                customerAddressTextBox.Text = data["address"];
                customerZipCodeTextBox.Text = data["zip_code"];
                customerPhoneNumberTextBox.Text = data["phone_number"];
                sqlAction = "put";
                addCustomerBtn.Text = "Update";
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show(String.Concat("Input mustn't be empty"));
                    return;
                }
            }
            DatabaseClass.clsCustomer newCustomer = new clsCustomer();
            newCustomer.setEmail(customerEmailTextBox.Text);
            newCustomer.setName(customerNameTextBox.Text);
            newCustomer.setAddress(customerAddressTextBox.Text);
            newCustomer.setZipCode(customerZipCodeTextBox.Text);
            newCustomer.setPhoneNumber(customerPhoneNumberTextBox.Text);

            try
            {
                if (sqlAction == "post")
                    newCustomer.Insert();
                else if (sqlAction == "put")
                {
                    newCustomer.setId(Convert.ToInt32(idCustomerValue.Text));
                    newCustomer.Update();
                }
                MessageBox.Show(String.Concat("Customer with code ", newCustomer.getEmail(), " has been ", sqlAction == "post" ? "added" : "updated", " successfully "));

                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Text = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cancelAddCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
