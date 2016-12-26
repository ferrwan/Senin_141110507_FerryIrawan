using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsProduct
    {
        private static string tableName = "product";
        public int id { private set; get; }
        public string code { private set; get; }
        public string name { private set; get; }
        public int initialAmount { private set; get; }
        public decimal hppPrice { private set; get; }
        public decimal sellingPrice { private set; get; }
        public DateTime createdAt { private set; get; }
        public DateTime updatedAt { private set; get; }

        public int getId()
        {
            return this.id;
        }
        public clsProduct setId(int id)
        {
            this.id = id;
            return this;
        }

        public string getCode()
        {
            return this.code;
        }
        public clsProduct setCode(string code)
        {
            this.code = code;
            return this;
        }
        public string getName()
        {
            return this.name;
        }
        public clsProduct setName(string name)
        {
            this.name = name;
            return this;
        }
        public int getInitialAmount()
        {
            return this.initialAmount;
        }
        public clsProduct setInitialAmount(int initialAmount)
        {
            this.initialAmount = initialAmount;
            return this;
        }
        public decimal getHppPrice()
        {
            return this.hppPrice;
        }
        public clsProduct setHppPrice(decimal hppPrice)
        {
            this.hppPrice = hppPrice;
            return this;
        }
        public decimal getSellingPrice()
        {
            return this.sellingPrice;
        }
        public clsProduct setSellingPrice(decimal sellingPrice)
        {
            this.sellingPrice = sellingPrice;
            return this;
        }
        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }
        public clsProduct setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }
        public DateTime getUpdatedAt()
        {
            return this.updatedAt;
        }
        public clsProduct setUpdatedAt(DateTime updatedAt)
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
        public static clsProduct SelectById(int id)
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

            clsProduct product = new clsProduct();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                product.setId(Convert.ToInt32(dr["id"]));
                product.setName(dr["name"].ToString());
                product.setCode(dr["code"].ToString());
                product.setInitialAmount(Convert.ToInt32(dr["initial_amount"]));
                product.setHppPrice(Convert.ToDecimal(dr["hpp_price"]));
                product.setSellingPrice(Convert.ToDecimal(dr["selling_price"]));
                product.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                product.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return product;
            }

            return null;
        }
        public void Insert()
        {
            string insertString = String.Concat("INSERT INTO ", tableName, " (code, name, initial_amount, hpp_price, selling_price, created_at, updated_at)", " VALUES (@code, @name, @initialAmount, @hppPrice, @sellingPrice, @createdAt, @updatedAt)");

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertString, clsDatabase.conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@initialAmount", initialAmount);
            cmd.Parameters.AddWithValue("@hppPrice", hppPrice);
            cmd.Parameters.AddWithValue("@sellingPrice", sellingPrice);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            try
            {
                clsDatabase.openConnection();
                cmd.ExecuteNonQuery();
                clsDatabase.closeConnection();
            }
            catch (Exception err)
            {
                clsDatabase.closeConnection();
                throw new Exception(err.Message);
            }
        }

        public void Update()
        {
            string updateString = String.Concat("UPDATE ", tableName, " SET code = @code, name = @name, initial_amount = @initialAmount, hpp_price = @hppPrice, ", "selling_price = @sellingPrice, updated_at = @updatedAt WHERE ID = @id");

            MySqlCommand cmd;
            cmd = new MySqlCommand(updateString, clsDatabase.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@initialAmount", initialAmount);
            cmd.Parameters.AddWithValue("@hppPrice", hppPrice);
            cmd.Parameters.AddWithValue("@sellingPrice", sellingPrice);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            try
            {
                clsDatabase.openConnection();
                cmd.ExecuteNonQuery();
                clsDatabase.closeConnection();
            }
            catch (Exception err)
            {
                clsDatabase.closeConnection();
                throw new Exception(err.Message);
            }
        }

        public void Delete()
        {
            string deleteString = String.Concat("DELETE FROM ", tableName ," WHERE ID = @id");

            MySqlCommand cmd;
            cmd = new MySqlCommand(deleteString, clsDatabase.conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                clsDatabase.openConnection();
                cmd.ExecuteNonQuery();
                clsDatabase.closeConnection();
            }
            catch (Exception err)
            {
                clsDatabase.closeConnection();
                throw new Exception(err.Message);
            }
        }
    }
}
