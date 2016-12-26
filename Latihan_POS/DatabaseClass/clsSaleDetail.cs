using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsSaleDetail
    {
        private static string tableName = "sale_detail";
        private int id;
        private clsSale sale;
        private clsProduct product;
        private decimal productPrice;
        private int quantity;
        private DateTime created_at;
        private DateTime updated_at;

        public clsSaleDetail()
        { }

        public int getId()
        {
            return this.id;
        }
        public clsSaleDetail setId(int id)
        {
            this.id = id;
            return this;
        }

        public clsSale getSale()
        {
            return this.sale;
        }
        public clsSaleDetail setSale(clsSale sale)
        {
            this.sale = sale;
            return this;
        }

        public clsProduct getProduct()
        {
            return this.product;
        }
        public clsSaleDetail setProduct(clsProduct product)
        {
            this.product = product;
            return this;
        }

        public int getQuantity()
        {
            return this.quantity;
        }
        public clsSaleDetail setQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }

        public decimal getProductPrice()
        {
            return this.productPrice;
        }

        public clsSaleDetail setProductPrice(decimal productPrice)
        {
            this.productPrice = productPrice;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public clsSaleDetail setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public clsSaleDetail setUpdatedAt(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this;
        }

        public static DataTable FindAll()
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

        public static DataTable SelectBySaleId(int sale_id)
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName, " WHERE sale_id = @saleId");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(select, clsDatabase.conn);
            da.SelectCommand.Parameters.AddWithValue("@saleId", sale_id);

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

        public static clsSaleDetail SelectById(int id)
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

            clsSaleDetail penjualanDetail = new clsSaleDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualanDetail.setId(Convert.ToInt32(dr["id"]));
                penjualanDetail.setProduct(clsProduct.SelectById(Convert.ToInt32(dr["product_id"])));
                penjualanDetail.setSale(clsSale.SelectById(Convert.ToInt32(dr["sale_id"])));
                penjualanDetail.setQuantity(Convert.ToInt32(dr["quantity"]));
                penjualanDetail.setProductPrice(Convert.ToDecimal(dr["product_price"]));
                penjualanDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualanDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualanDetail;
            }

            return null;
        }

        public static clsSaleDetail SelectByProductIdAndSaleId(int product_id, int sale_id)
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName, " WHERE product_id = @productId AND sale_id = @saleId");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(select, clsDatabase.conn);
            da.SelectCommand.Parameters.AddWithValue("@productId", product_id);
            da.SelectCommand.Parameters.AddWithValue("@saleId", sale_id);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clsDatabase.closeConnection();

            clsSaleDetail penjualanDetail = new clsSaleDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualanDetail.setId(Convert.ToInt32(dr["id"]));
                penjualanDetail.setProduct(clsProduct.SelectById(Convert.ToInt32(dr["product_id"])));
                penjualanDetail.setSale(clsSale.SelectById(Convert.ToInt32(dr["sale_id"])));
                penjualanDetail.setQuantity(Convert.ToInt32(dr["quantity"]));
                penjualanDetail.setProductPrice(Convert.ToDecimal(dr["product_price"]));
                penjualanDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualanDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualanDetail;
            }

            return null;
        }

        public void Insert()
        {
            MySqlCommand cmd = clsDatabase.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", tableName, "(sale_id, product_id, product_price, quantity, created_at, updated_at) VALUES (@saleId, @productId, @productPrice, @quantity, @createdAt, @updatedAt)");

            cmd.Parameters.AddWithValue("@saleId", this.sale.getId());
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
            string cmdText = String.Concat("UPDATE ", tableName, " SET sale_id = @saleId, product_id = @productId, product_price = @productPrice, quantity = @quantity, updated_at = @updatedAt WHERE id = @id");

            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@saleId", this.sale.getId());
            cmd.Parameters.AddWithValue("@productId", this.product.getId());
            cmd.Parameters.AddWithValue("@productPrice", this.productPrice);
            cmd.Parameters.AddWithValue("@quantity", this.quantity);
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
