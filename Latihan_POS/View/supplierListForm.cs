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
    public partial class SupplierListForm : MaterialForm
    {
        private DataTable dtSupplier;
        public SupplierListForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FormListSupplier_Load(object sender, EventArgs e)
        {
            displayData();

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            dgvSupplier.Columns.Add(editBtn);
            editBtn.HeaderText = "";
            editBtn.Text = "Edit";
            editBtn.Name = "editBtn";
            editBtn.UseColumnTextForButtonValue = true;
            dgvSupplier.Columns.Add(deleteBtn);
            deleteBtn.HeaderText = "";
            deleteBtn.Text = "Delete";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.UseColumnTextForButtonValue = true;
        }
        private void displayData()
        {
            dgvSupplier.DataSource = DatabaseClass.clsSupplier.SelectAll();
            dgvSupplier.Refresh();
            dtSupplier = (DataTable)dgvSupplier.DataSource;
        }
        private void supplierFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvSupplier.DataSource;
            foreach (DataColumn col in dtSupplier.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += String.Concat(col.ColumnName, " like '%", supplierFilterTextBox.Text, "%'");
                i++;
            }
            bs.Filter = filter;
            dgvSupplier.DataSource = bs;
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Dictionary<string, string> data = new Dictionary<string, string> { };
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string actionType = dgvSupplier[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (actionType == "Edit")
                {
                    foreach (DataGridViewColumn col in dgvSupplier.Columns)
                    {
                        if (col.Name != "Edit" && col.Name != "Delete")
                        {
                            data.Add(col.Name, dgvSupplier[col.Index, e.RowIndex].Value.ToString());
                        }
                    }
                    SupplierForm supplierForm = new SupplierForm(data, actionType);
                    supplierForm.ShowDialog();
                    displayData();
                }
                else if (actionType == "Delete")
                {
                    clsSupplier delProduct = new clsSupplier();
                    int id = Convert.ToInt32(dtSupplier.Rows[e.RowIndex]["id"]);
                    string email = dtSupplier.Rows[e.RowIndex]["email"].ToString();
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
