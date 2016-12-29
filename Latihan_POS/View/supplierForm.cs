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
    public partial class SupplierForm : MaterialForm
    {
        private string sqlAction = "post";
        public SupplierForm(Dictionary<string, string> data = null, string action = null)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            if (data != null && action == "Edit")
            {
                idSupplierLabel.Visible = idSupplierValue.Visible = true;
                idSupplierValue.Text = data["id"];
                supplierEmailTextBox.Text = data["email"];
                supplierNameTextBox.Text = data["name"];
                supplierAddressTextBox.Text = data["address"];
                supplierZipCodeTextBox.Text = data["zip_code"];
                supplierPhoneNumberTextBox.Text = data["phone_number"];
                sqlAction = "put";
                addSupplierBtn.Text = "Update";
            }
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim() == "")
                {
                    MessageBox.Show(String.Concat("Input mustn't be empty"));
                    return;
                }
            }
            DatabaseClass.clsSupplier newSupplier = new clsSupplier();
            newSupplier.setEmail(supplierEmailTextBox.Text);
            newSupplier.setName(supplierNameTextBox.Text);
            newSupplier.setAddress(supplierAddressTextBox.Text);
            newSupplier.setZipCode(supplierZipCodeTextBox.Text);
            newSupplier.setPhoneNumber(supplierPhoneNumberTextBox.Text);

            try
            {
                if (sqlAction == "post")
                    newSupplier.Insert();
                else if (sqlAction == "put")
                {
                    newSupplier.setId(Convert.ToInt32(idSupplierValue.Text));
                    newSupplier.Update();
                }
                MessageBox.Show(String.Concat("Supplier with code ", newSupplier.getEmail(), " has been ", sqlAction == "post" ? "added" : "updated", " successfully "));

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

        private void cancelAddSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
