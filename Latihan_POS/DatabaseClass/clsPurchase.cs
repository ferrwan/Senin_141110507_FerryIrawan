using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsPurchase
    {
        private static string tableName = "purchase";
        private int id;
        private string code;
        private clsSupplier supplier;
        private DateTime created_at;
        private DateTime updated_at;

        public clsPurchase()
        { }

        public int getId()
        {
            return this.id;
        }
        public clsPurchase setId(int id)
        {
            this.id = id;
            return this;
        }
        public string getCode()
        {
            return this.code;
        }

        public clsPurchase setCode(string code)
        {
            this.code = code;
            return this;
        }

        public clsSupplier getSupplier()
        {
            return this.supplier;
        }
        public clsPurchase setSupplier(clsSupplier supplier)
        {
            this.supplier = supplier;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public clsPurchase setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public clsPurchase setUpdatedAt(DateTime updated_at)
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
        public static clsPurchase SelectById(int id)
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

            clsPurchase purchase = new clsPurchase();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                purchase.setId(Convert.ToInt32(dr["id"]));
                purchase.setCode(dr["code"].ToString());
                purchase.setSupplier(clsSupplier.SelectById(Convert.ToInt16(dr["supplier_id"])));
                purchase.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                purchase.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return purchase;
            }
            return null;
        }
        public static clsPurchase SelectByCode(string code)
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

            clsPurchase purchase = new clsPurchase();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                purchase.setId(Convert.ToInt32(dr["id"]));
                purchase.setCode(dr["code"].ToString());
                purchase.setSupplier(clsSupplier.SelectById(Convert.ToInt16(dr["supplier_id"])));
                purchase.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                purchase.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return purchase;
            }
            return null;
        }

        public void Insert()
        {
            MySqlCommand cmd = clsDatabase.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", tableName, "(supplier_id, code , created_at, updated_at)  VALUES (@supplierId, @code, @created_at, @updated_at)");
            cmd.Parameters.AddWithValue("@supplierId", this.supplier.getId());
            cmd.Parameters.AddWithValue("@code", this.code);
            cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

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
            string cmdText = String.Concat("UPDATE ", tableName, " SET supplier_id = @supplierId, code = @code, updated_at = @updated_at WHERE id = @id");

            cmd.Parameters.AddWithValue("@supplierId", this.supplier.getId());
            cmd.Parameters.AddWithValue("@code", this.code);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
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
