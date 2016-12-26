using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsSale
    {
        private static string tableName = "sale";
        private int id;
        private string code;
        private clsCustomer customer;
        private DateTime created_at;
        private DateTime updated_at;

        public clsSale()
        { }

        public int getId()
        {
            return this.id;
        }
        public clsSale setId(int id)
        {
            this.id = id;
            return this;
        }
        public string getCode()
        {
            return this.code;
        }

        public clsSale setCode(string code)
        {
            this.code = code;
            return this;
        }

        public clsCustomer getCustomer()
        {
            return this.customer;
        }
        public clsSale setCustomer(clsCustomer customer)
        {
            this.customer = customer;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public clsSale setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public clsSale setUpdatedAt(DateTime updated_at)
        {
            this.updated_at = updated_at;
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
        public static clsSale SelectById(int id)
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

            clsSale penjualan = new clsSale();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualan.setId(Convert.ToInt32(dr["id"]));
                penjualan.setCode(dr["code"].ToString());
                penjualan.setCustomer(clsCustomer.SelectById(Convert.ToInt16(dr["customer_id"])));
                penjualan.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualan.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualan;
            }
            return null;
        }
        public static clsSale SelectByCode(string code)
        {
            clsDatabase.openConnection();
            string select = String.Concat("SELECT * FROM ", tableName, " WHERE code = @code");

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(select, clsDatabase.conn);
            da.SelectCommand.Parameters.AddWithValue("@code", code);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clsDatabase.closeConnection();

            clsSale penjualan = new clsSale();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualan.setId(Convert.ToInt32(dr["id"]));
                penjualan.setCode(dr["code"].ToString());
                penjualan.setCustomer(clsCustomer.SelectById(Convert.ToInt16(dr["customer_id"])));
                penjualan.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualan.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualan;
            }
            return null;
        }

        public void Insert()
        {
            MySqlCommand cmd = clsDatabase.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", tableName, "(customer_id, code, created_at, updated_at) VALUES (@customerId, @code, @createdAt, @updatedAt)");
            cmd.Parameters.AddWithValue("@customerId", this.customer.getId());
            cmd.Parameters.AddWithValue("@code", this.code);
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
            string cmdText = String.Concat("UPDATE " ,tableName, " SET customer_id = @customerId, code = @code, updated_at = @updatedAt WHERE id = @id");

            cmd.Parameters.AddWithValue("@customerId", this.customer.getId());
            cmd.Parameters.AddWithValue("@code", this.code);
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
            string cmdText = string.Concat("DELETE FROM ", tableName, " WHERE id = @id");
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
