using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsPurchaseDetail
    {
        private static string tableName = "purchase_detail";
        private int id;
        private clsPurchase purchase;
        private clsProduct product;
        private decimal productPrice;
        private int quantity;
        private DateTime createdAt;
        private DateTime updatedAt;

        public clsPurchaseDetail()
        { }

        public int getId()
        {
            return this.id;
        }
        public clsPurchaseDetail setId(int id)
        {
            this.id = id;
            return this;
        }

        public clsPurchase getPurchase()
        {
            return this.purchase;
        }
        public clsPurchaseDetail setPurchase(clsPurchase purchase)
        {
            this.purchase = purchase;
            return this;
        }

        public clsProduct getProduct()
        {
            return this.product;
        }
        public clsPurchaseDetail setProduct(clsProduct product)
        {
            this.product = product;
            return this;
        }

        public int getQuantity()
        {
            return this.quantity;
        }
        public clsPurchaseDetail setQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }

        public decimal getProductPrice()
        {
            return this.productPrice;
        }

        public clsPurchaseDetail setProductPrice(decimal productPrice)
        {
            this.productPrice = productPrice;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

        public clsPurchaseDetail setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updatedAt;
        }

        public clsPurchaseDetail setUpdatedAt(DateTime updatedAt)
        {
            this.updatedAt = updatedAt;
            return this;
        }

        public static DataTable SelectAll()
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName);

            MySqlDataAdapter da = new MySqlDataAdapter(select, clsDatabase.conn);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clsDatabase.closeConnection();

            DataTable dt = ds.Tables[0].Clone();

            foreach (DataColumn dc in dt.Columns)
            {
                dc.DataType = typeof(string);
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dt.ImportRow(row);
            }
            return dt;
        }

        public static DataTable SelectByPurchaseId(int purchaseId)
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName, " WHERE purchase_id = @purchaseId");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(select, clsDatabase.conn);
            da.SelectCommand.Parameters.AddWithValue("@purchaseId", purchaseId);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clsDatabase.closeConnection();

            DataTable dt = ds.Tables[0].Clone();

            foreach (DataColumn dc in dt.Columns)
            {
                dc.DataType = typeof(string);
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dt.ImportRow(row);
            }
            return dt;
        }

        public static clsPurchaseDetail SelectById(int id)
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName, " WHERE id = @id");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(select, clsDatabase.conn);
            da.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clsDatabase.closeConnection();

            clsPurchaseDetail purchaseDetail = new clsPurchaseDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                purchaseDetail.setId(Convert.ToInt32(dr["id"]));
                purchaseDetail.setProduct(clsProduct.SelectById(Convert.ToInt32(dr["product_id"])));
                purchaseDetail.setPurchase(clsPurchase.SelectById(Convert.ToInt32(dr["purchase_id"])));
                purchaseDetail.setQuantity(Convert.ToInt32(dr["quantity"]));
                purchaseDetail.setProductPrice(Convert.ToDecimal(dr["product_price"]));
                purchaseDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                purchaseDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return purchaseDetail;
            }

            return null;
        }

        public static clsPurchaseDetail SelectByProductIdAndPurchaseId(int productId, int purchaseId)
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName, " WHERE product_id = @productId AND purchase_id = @purchaseId");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(select, clsDatabase.conn);
            da.SelectCommand.Parameters.AddWithValue("@productId", productId);
            da.SelectCommand.Parameters.AddWithValue("@purchaseId", purchaseId);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clsDatabase.closeConnection();

            clsPurchaseDetail purchaseDetail = new clsPurchaseDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                purchaseDetail.setId(Convert.ToInt32(dr["id"]));
                purchaseDetail.setProduct(clsProduct.SelectById(Convert.ToInt32(dr["product_id"])));
                purchaseDetail.setPurchase(clsPurchase.SelectById(Convert.ToInt32(dr["purchase_id"])));
                purchaseDetail.setQuantity(Convert.ToInt32(dr["quantity"]));
                purchaseDetail.setProductPrice(Convert.ToDecimal(dr["product_price"]));
                purchaseDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                purchaseDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return purchaseDetail;
            }

            return null;
        }

        public void Insert()
        {
            MySqlCommand cmd = clsDatabase.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", tableName, "(purchase_id, product_id, product_price, quantity, created_at, updated_at) VALUES (@purchaseId, @productId, @productPrice, @quantity, @createdAt, @updatedAt)");

            cmd.Parameters.AddWithValue("@purchaseId", this.purchase.getId());
            cmd.Parameters.AddWithValue("@productId", this.product.getId());
            cmd.Parameters.AddWithValue("@productPrice", this.productPrice);
            cmd.Parameters.AddWithValue("@quantity", this.quantity);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);

            cmd.CommandText = cmdText;
            try
            {
                clsDatabase.openConnection();
                cmd.ExecuteNonQuery();
                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                clsDatabase.closeConnection();
                throw new Exception(ex.Message);
            }
        }

        public void Update()
        {
            MySqlCommand cmd = clsDatabase.conn.CreateCommand();
            string cmdText = String.Concat("UPDATE " + tableName + " SET purchase_id = @purchaseId, product_id = @productId, product_price = @productPrice, quantity = @quantity, updated_at = @updatedAt WHERE id = @id");

            cmd.Parameters.AddWithValue("@purchaseId", this.purchase.getId());
            cmd.Parameters.AddWithValue("@productId", this.product.getId());
            cmd.Parameters.AddWithValue("@productPrice", this.productPrice);
            cmd.Parameters.AddWithValue("@quantity", this.quantity);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            cmd.CommandText = cmdText;
            try
            {
                clsDatabase.openConnection();
                cmd.ExecuteNonQuery();
                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                clsDatabase.closeConnection();
                throw new Exception(ex.Message);
            }
        }

        public void Delete()
        {
            MySqlCommand cmd = clsDatabase.conn.CreateCommand();
            string cmdText = String.Concat("DELETE FROM ", tableName, " WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.CommandText = cmdText;
            try
            {
                clsDatabase.openConnection();
                cmd.ExecuteNonQuery();
                clsDatabase.closeConnection();
            }
            catch (Exception ex)
            {
                clsDatabase.closeConnection();
                throw new Exception(ex.Message);
            }
        }
    }
}
