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
    public partial class ProductListForm : MaterialForm
    {
        private DataTable dtProduct;
        public ProductListForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen700, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ListProductForm_Load(object sender, EventArgs e)
        {
            displayData();

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            dgvProduct.Columns.Add(editBtn);
            editBtn.HeaderText = "";
            editBtn.Text = "Edit";
            editBtn.Name = "editBtn";
            editBtn.UseColumnTextForButtonValue = true;
            dgvProduct.Columns.Add(deleteBtn);
            deleteBtn.HeaderText = "";
            deleteBtn.Text = "Delete";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.UseColumnTextForButtonValue = true;
        }
        private void displayData()
        {
            dgvProduct.DataSource = DatabaseClass.clsProduct.SelectAll();
            dgvProduct.Refresh();
            dtProduct = (DataTable)dgvProduct.DataSource;
        }

        private void productFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvProduct.DataSource;
            foreach(DataColumn col in dtProduct.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += String.Concat(col.ColumnName, " like '%", customerFilterTextBox.Text, "%'");
                i++;
            }
            bs.Filter = filter;
            dgvProduct.DataSource = bs;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Dictionary<string, string> data = new Dictionary<string, string> { };
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string actionType = dgvProduct[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (actionType == "Edit")
                {
                    foreach(DataGridViewColumn col in dgvProduct.Columns)
                    {
                        if (col.Name != "Edit" && col.Name != "Delete")
                        {
                            data.Add(col.Name, dgvProduct[col.Index, e.RowIndex].Value.ToString());
                        }
                    }
                    ProductForm productForm = new ProductForm(data, actionType);
                    productForm.ShowDialog();
                    displayData();
                }
                else if(actionType == "Delete")
                {
                    clsProduct delProduct = new clsProduct();
                    int id = Convert.ToInt32(dtProduct.Rows[e.RowIndex]["id"]);
                    string code = dtProduct.Rows[e.RowIndex]["code"].ToString();
                    delProduct.setId(id);
                    delProduct.setCode(code);
                    try
                    {
                        delProduct.Delete();
                        MessageBox.Show(String.Concat("Product with code ", delProduct.getCode(), " has been deleted successfully "));
                        displayData();
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
    }
}
