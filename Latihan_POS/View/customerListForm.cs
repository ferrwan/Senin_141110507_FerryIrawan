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
    public partial class CustomerListForm : MaterialForm
    {
        private DataTable dtCustomer;
        public CustomerListForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FormListCustomer_Load(object sender, EventArgs e)
        {
            displayData();

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            dgvCustomer.Columns.Add(editBtn);
            editBtn.HeaderText = "";
            editBtn.Text = "Edit";
            editBtn.Name = "editBtn";
            editBtn.UseColumnTextForButtonValue = true;
            dgvCustomer.Columns.Add(deleteBtn);
            deleteBtn.HeaderText = "";
            deleteBtn.Text = "Delete";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.UseColumnTextForButtonValue = true;
        }
        private void displayData()
        {
            dgvCustomer.DataSource = DatabaseClass.clsCustomer.SelectAll();
            dgvCustomer.Refresh();
            dtCustomer = (DataTable)dgvCustomer.DataSource;
        }
        private void customerFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCustomer.DataSource;
            foreach (DataColumn col in dtCustomer.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += String.Concat(col.ColumnName, " like '%", customerFilterTextBox.Text, "%'");
                i++;
            }
            bs.Filter = filter;
            dgvCustomer.DataSource = bs;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Dictionary<string, string> data = new Dictionary<string, string> { };
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string actionType = dgvCustomer[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (actionType == "Edit")
                {
                    foreach (DataGridViewColumn col in dgvCustomer.Columns)
                    {
                        if (col.Name != "Edit" && col.Name != "Delete")
                        {
                            data.Add(col.Name, dgvCustomer[col.Index, e.RowIndex].Value.ToString());
                        }
                    }
                    CustomerForm customerForm= new CustomerForm(data, actionType);
                    customerForm.ShowDialog();
                    displayData();
                }
                else if (actionType == "Delete")
                {
                    clsCustomer delProduct = new clsCustomer();
                    int id = Convert.ToInt32(dtCustomer.Rows[e.RowIndex]["id"]);
                    string email = dtCustomer.Rows[e.RowIndex]["email"].ToString();
                    delProduct.setId(id);
                    delProduct.setEmail(email);
                    try
                    {
                        delProduct.Delete();
                        MessageBox.Show(String.Concat("Product with code ", delProduct.getEmail(), " has been deleted successfully "));
                        displayData();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
    }
}
