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
    public partial class MainTransactionForm : MaterialForm
    {
        private int saleProductId;
        private int purchaseProductId;
        private int customerId;
        private int supplierId;
        private DataTable dtTransaction = new DataTable();
        private DataTable dtSelectedTransaction = new DataTable();
        public MainTransactionForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.BlueGrey900, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainTransactionForm_Load(object sender, EventArgs e)
        {
            dtTransaction = clsPurchase.SelectAll();
            if (dtTransaction.Rows.Count > 0)
            {
                dgvListTransaction.DataSource = dtTransaction;
                dgvListTransaction.Refresh();
                selectedTransactionLabel.Text = String.Concat("Purchase Code: ", dtTransaction.Rows[0]["code"].ToString());

                dtSelectedTransaction = clsPurchaseDetail.SelectByPurchaseId(Convert.ToInt32(dtTransaction.Rows[0]["id"]));
                dgvListSelectedTransaction.DataSource = dtSelectedTransaction;
                dgvListSelectedTransaction.Refresh();
            }
        }

        private void purchaseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            dtTransaction = new DataTable();
            if (purchaseRadioBtn.Checked)
            {
                dtTransaction = clsPurchase.SelectAll();
                if (dtTransaction.Rows.Count > 0)
                {
                    dgvListTransaction.DataSource = dtTransaction;
                    dgvListTransaction.Refresh();
                    selectedTransactionLabel.Text = String.Concat("Purchase Code: ", dtTransaction.Rows[0]["code"].ToString());

                    dtSelectedTransaction = clsPurchaseDetail.SelectByPurchaseId(Convert.ToInt32(dtTransaction.Rows[0]["id"]));
                }
            }
            else
            {
                dtTransaction = clsSale.SelectAll();
                {
                    dgvListTransaction.DataSource = dtTransaction;
                    dgvListTransaction.Refresh();
                    selectedTransactionLabel.Text = String.Concat("Sale Code: ", dtTransaction.Rows[0]["code"].ToString());

                    dtSelectedTransaction = clsSaleDetail.SelectBySaleId(Convert.ToInt32(dtTransaction.Rows[0]["id"]));
                }
            }
            dgvListSelectedTransaction.DataSource = dtSelectedTransaction;
            dgvListSelectedTransaction.Refresh();
        }

        private void dgvListTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string transType;
            if (e.RowIndex < 0)
                return;
            else
            {
                if (purchaseRadioBtn.Checked)
                {
                    transType = "Purchase";
                    dtSelectedTransaction = clsPurchaseDetail.SelectByPurchaseId(Convert.ToInt32(dtTransaction.Rows[e.RowIndex]["id"]));
                }
                else
                {
                    transType = "Sale";
                    dtSelectedTransaction = clsSaleDetail.SelectBySaleId(Convert.ToInt32(dtTransaction.Rows[e.RowIndex]["id"]));
                }
                selectedTransactionLabel.Text = String.Concat(transType, " Code: ", dtTransaction.Rows[e.RowIndex]["code"].ToString());
                dgvListSelectedTransaction.DataSource = dtSelectedTransaction;
                dgvListSelectedTransaction.Refresh();
            }
        }
        private Dictionary<string, string> getBrowse(string type)
        {
            BrowseForm browseForm = new BrowseForm(type);
            browseForm.ShowDialog();
            Dictionary<string, string> datas = browseForm.getData();
            return datas;
        }

        private void customerBrowseBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = getBrowse("Customer");
            if (datas.Count > 0)
            {
                customerId = Convert.ToInt32(datas["id"]);
                customerTextbox.Text = String.Concat(datas["name"], " - (id: ", customerId, ")");
            }
        }

        private void supplierBrowseBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = getBrowse("Supplier");
            if (datas.Count > 0)
            {
                supplierId = Convert.ToInt32(datas["id"]);
                supplierTextbox.Text = String.Concat(datas["name"], " - (id: ", supplierId, ")");
            }

        }

        private void saleProductBrowseBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = getBrowse("Product");
            if (datas.Count > 0)
            {
                saleProductId = Convert.ToInt32(datas["id"]);
                saleProductTextbox.Text = datas["name"];
                saleProductPriceTextbox.Text = datas["selling_price"];
            }
        }

        private void saleCodeBrowseBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = getBrowse("Sale");
            if(datas.Count > 0)
            {
                clsCustomer customer = clsCustomer.SelectById(Convert.ToInt32(datas["customer_id"]));
                customerId = customer.getId();
                saleCodeTextbox.Text = datas["code"];
                customerTextbox.Text = customer.getName();
                DataTable dt = clsSaleDetail.SelectBySaleId(Convert.ToInt32(datas["id"]));
                dgvSaleItems.DataSource = dt;
                dgvSaleItems.Refresh();

                decimal totalPrice = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    totalPrice += Convert.ToDecimal(dr["product_price"]) * Convert.ToInt32(dr["quantity"]);
                }
                saleTotalPriceLabel.Text = totalPrice.ToString();
            }
        }

        private void purchaseCodeBrowseBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = getBrowse("Purchase");
            if (datas.Count > 0)
            {
                clsSupplier supplier = clsSupplier.SelectById(Convert.ToInt32(datas["supplier_id"]));
                supplierId = supplier.getId();
                saleCodeTextbox.Text = datas["code"];
                supplierTextbox.Text = supplier.getName();
                DataTable dt = clsPurchaseDetail.SelectByPurchaseId(Convert.ToInt32(datas["id"]));
                dgvPurchaseItems.DataSource = dt;
                dgvPurchaseItems.Refresh();

                decimal totalPrice = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    totalPrice += Convert.ToDecimal(dr["product_price"]) * Convert.ToInt32(dr["quantity"]);
                }
                saleTotalPriceLabel.Text = totalPrice.ToString();
            }
        }

        private void purchaseProductBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> datas = getBrowse("Product");
            if (datas.Count > 0)
            {
                purchaseProductId = Convert.ToInt32(datas["id"]);
                purchaseProductTextbox.Text = datas["name"];
                purchaseProductPriceTextbox.Text = datas["selling_price"];
            }
        }

        private void saleQuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            saleSubTotalTextBox.Text = (Convert.ToInt32(saleQuantityTextbox.Text) * Convert.ToDecimal(saleProductPriceTextbox.Text)).ToString();
        }

        private void purchaseQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            purchaseSubtotalPriceTextBox.Text = (Convert.ToInt32(purchaseQuantityTextbox.Text) * Convert.ToDecimal(purchaseProductPriceTextbox.Text)).ToString();
        }

        private void saleAddBtn_Click(object sender, EventArgs e)
        {
            foreach(Control c in saleTab.Controls)
            {
                if(c is TextBox && c.Text.Trim() == "")
                {
                    MessageBox.Show("Input mustn't be empty!");
                    return;
                }
            }

            clsSale sale = clsSale.SelectByCode(saleCodeTextbox.Text),
                    newSale = new clsSale();

            if(sale == null)
            {
                newSale.setCustomer(clsCustomer.SelectById(customerId));
                newSale.setCode(saleCodeTextbox.Text);
                try
                {
                    newSale.Insert();
                    sale = clsSale.SelectByCode(saleCodeTextbox.Text);
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            clsSaleDetail saleDetail = clsSaleDetail.SelectByProductIdAndSaleId(saleProductId, sale.getId());
            int quantity = Convert.ToInt32(saleQuantityTextbox.Text);
            if(saleDetail == null)
            {
                clsSaleDetail saleDetailNew = new clsSaleDetail();
                saleDetailNew.setProduct(clsProduct.SelectById(saleProductId));
                clsProduct product = saleDetailNew.getProduct();
                if(quantity < 0)
                {
                    MessageBox.Show("Quantity not valid");
                }
                else if(quantity > product.getInitialAmount())
                {
                    MessageBox.Show("Can't afford the quantity of the product");
                }
                else
                {
                    saleDetailNew.setQuantity(quantity);
                    saleDetailNew.setProductPrice(Convert.ToDecimal(saleProductPriceTextbox.Text));
                    saleDetailNew.setSale(sale);
                    try
                    {
                        saleDetailNew.Insert();
                        product.setInitialAmount(product.getInitialAmount() - quantity);
                        product.Update();
                        MessageBox.Show(String.Concat("Product with code ", saleDetailNew.getProduct().getCode(), " has been successfully added in sale with code ", sale.getCode()));
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            else
            {
                clsProduct product = saleDetail.getProduct();
                int lastQuantity = saleDetail.getQuantity();
                saleDetail.setQuantity(quantity);
                saleDetail.setProductPrice(Convert.ToDecimal(saleProductPriceTextbox.Text));
                if(quantity < 0)
                {
                    MessageBox.Show("Quantity not valid");
                }
                else if(quantity > product.getInitialAmount() + lastQuantity)
                {
                    MessageBox.Show("Can't afford the quantity of the product");
                }
                else
                {
                    try
                    {
                        saleDetail.Update();
                        product.setInitialAmount(product.getInitialAmount() - quantity + lastQuantity);
                        product.Update();
                        MessageBox.Show(String.Concat("Product with code ", saleDetail.getProduct().getCode(), " has been successfully added in sale with code ", sale.getCode()));
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            DataTable dt = clsSaleDetail.SelectBySaleId(sale.getId());
            dgvSaleItems.DataSource = dt;
            dgvSaleItems.Refresh();

            decimal totalPrice = 0;
            foreach (DataRow dr in dt.Rows)
            {
                totalPrice += Convert.ToDecimal(dr["product_price"]) * Convert.ToInt32(dr["quantity"]);
            }
            saleTotalPriceLabel.Text = totalPrice.ToString();
        }

        private void purchaseAddButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in purchaseTab.Controls)
            {
                if (c is TextBox && c.Text.Trim() == "" && c.Name != "purchaseSubtotalPriceTextBox")
                {
                    MessageBox.Show("Input mustn't be empty!");
                    return;
                }
            }

            clsPurchase purchase = clsPurchase.SelectByCode(purchaseCodeTextBox.Text),
                    newPurchase = new clsPurchase();

            if (purchase == null)
            {
                newPurchase.setSupplier(clsSupplier.SelectById(supplierId));
                newPurchase.setCode(purchaseCodeTextBox.Text);
                try
                {
                    newPurchase.Insert();
                    purchase = clsPurchase.SelectByCode(purchaseCodeTextBox.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            clsPurchaseDetail purchaseDetail = clsPurchaseDetail.SelectByProductIdAndPurchaseId(purchaseProductId, purchase.getId());
            int quantity = Convert.ToInt32(purchaseQuantityTextbox.Text);
            if (purchaseDetail == null)
            {
                clsPurchaseDetail purchaseDetailNew = new clsPurchaseDetail();
                purchaseDetailNew.setProduct(clsProduct.SelectById(purchaseProductId));
                clsProduct product = purchaseDetailNew.getProduct();
                if (quantity < 0)
                {
                    MessageBox.Show("Quantity not valid");
                }
                else
                {
                    purchaseDetailNew.setQuantity(quantity);
                    purchaseDetailNew.setProductPrice(Convert.ToDecimal(purchaseProductPriceTextbox.Text));
                    purchaseDetailNew.setPurchase(purchase);
                    try
                    {
                        purchaseDetailNew.Insert();
                        product.setInitialAmount(product.getInitialAmount() + quantity);
                        product.setHppPrice(purchaseDetailNew.getProductPrice());
                        product.Update();
                        MessageBox.Show(String.Concat("Product with code ", purchaseDetailNew.getProduct().getCode(), " has been successfully added in purchase with code ", purchase.getCode()));
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            else
            {
                clsProduct product = purchaseDetail.getProduct();
                int lastQuantity = purchaseDetail.getQuantity();
                purchaseDetail.setQuantity(quantity);
                purchaseDetail.setProductPrice(Convert.ToDecimal(purchaseProductPriceTextbox.Text));
                if (quantity < 0)
                {
                    MessageBox.Show("Quantity not valid");
                }
                else
                {
                    try
                    {
                        purchaseDetail.Update();
                        product.setInitialAmount(product.getInitialAmount() + quantity - lastQuantity);
                        product.setHppPrice(purchaseDetail.getProductPrice());
                        product.Update();
                        MessageBox.Show(String.Concat("Product with code ", purchaseDetail.getProduct().getCode(), " has been successfully added in purchase with code ", purchase.getCode()));
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            DataTable dt = clsPurchaseDetail.SelectByPurchaseId(purchase.getId());
            dgvPurchaseItems.DataSource = dt;
            dgvPurchaseItems.Refresh();

            decimal totalPrice = 0;
            foreach (DataRow dr in dt.Rows)
            {
                totalPrice += Convert.ToDecimal(dr["product_price"]) * Convert.ToInt32(dr["quantity"]);
            }
            purchaseTotalPriceLabel.Text = totalPrice.ToString();
        }
    }
}
