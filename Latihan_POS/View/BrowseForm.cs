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
    public partial class BrowseForm : Form
    {
        private Dictionary<string, string> datas;
        private DataTable dt;
        public BrowseForm(string tableType)
        {
            InitializeComponent();

            browseLabel.Text = String.Concat(tableType, " List");
            if (tableType == "Product")
            {
                dgvBrowse.DataSource = clsProduct.SelectAll();
            }
            else if (tableType == "Customer")
            {
                dgvBrowse.DataSource = clsCustomer.SelectAll();
            }
            else if (tableType == "Supplier")
            {
                dgvBrowse.DataSource = clsSupplier.SelectAll();
            }
            else if (tableType == "Purchase")
            {
                dgvBrowse.DataSource = clsPurchase.SelectAll();
            }
            else if (tableType == "Sale")
            {
                dgvBrowse.DataSource = clsSale.SelectAll();
            }
            dgvBrowse.Refresh();
            datas = new Dictionary<string, string> { };
            dt = (DataTable)dgvBrowse.DataSource;
        }

        public Dictionary<string, string> getData()
        {
            return this.datas;
        }

        private void dgvBrowseClick(object sender, DataGridViewCellEventArgs e)
        {
            datas = new Dictionary<string, string> { };
            foreach (DataGridViewColumn col in dgvBrowse.Columns)
            {
                datas.Add(col.Name, dgvBrowse[col.Index, e.RowIndex].Value.ToString());
            }
            Close();
        }
    }
}
