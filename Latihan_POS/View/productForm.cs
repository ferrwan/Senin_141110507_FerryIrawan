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
    public partial class ProductForm : MaterialForm
    {
        private string sqlAction = "post";
        public ProductForm(Dictionary<string, string> data = null, string action = null)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen700, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            if (data != null && action == "Edit")
            {
                idProductLabel.Visible = idProductValue.Visible = true;
                idProductValue.Text = data["id"];
                productCodeTextBox.Text = data["code"];
                productNameTextBox.Text = data["name"];
                productInitialAmountTextBox.Text = data["initial_amount"];
                productHppPriceTextBox.Text = data["hpp_price"];
                productSellingPriceTextBox.Text = data["selling_price"];
                sqlAction = "put";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if(tb.Text.Trim() == "")
                {
                    MessageBox.Show(String.Concat("Input mustn't be empty"));
                    return;
                }
            }
            DatabaseClass.clsProduct newProduct = new clsProduct();
            newProduct.setCode(productCodeTextBox.Text);
            newProduct.setName(productNameTextBox.Text);
            newProduct.setInitialAmount(Convert.ToInt32(productInitialAmountTextBox.Text));
            newProduct.setHppPrice(Convert.ToDecimal(productHppPriceTextBox.Text));
            newProduct.setSellingPrice(Convert.ToDecimal(productSellingPriceTextBox.Text));

            try
            {
                if (sqlAction == "post")
                    newProduct.Insert();
                else if (sqlAction == "put")
                {
                    newProduct.setId(Convert.ToInt32(idProductValue.Text));
                    newProduct.Update();
                }
                MessageBox.Show(String.Concat("Product with code ", newProduct.getCode()," has been ", sqlAction == "post" ? "added" : "updated" ," successfully "));

                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Text = "";
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cancelAddProductBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
