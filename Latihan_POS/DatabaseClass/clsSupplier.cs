using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsSupplier
    {
        private static string tableName = "supplier";
        public int id { private set; get; }
        public string email { private set; get; }
        public string name { private set; get; }
        public string address { private set; get; }
        public string zipCode { private set; get; }
        public string phoneNumber { private set; get; }
        public DateTime createdAt { private set; get; }
        public DateTime updatedAt { private set; get; }

        public int getId()
        {
            return this.id;
        }
        public clsSupplier setId(int id)
        {
            this.id = id;
            return this;
        }

        public string getEmail()
        {
            return this.email;
        }
        public clsSupplier setEmail(string email)
        {
            this.email = email;
            return this;
        }
        public string getName()
        {
            return this.name;
        }
        public clsSupplier setName(string name)
        {
            this.name = name;
            return this;
        }
        public string getAddress()
        {
            return this.address;
        }
        public clsSupplier setAddress(string address)
        {
            this.address = address;
            return this;
        }
        public string getZipCode()
        {
            return this.zipCode;
        }
        public clsSupplier setZipCode(string zipCode)
        {
            this.zipCode = zipCode;
            return this;
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public clsSupplier setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }
        public clsSupplier setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }
        public DateTime getUpdatedAt()
        {
            return this.updatedAt;
        }
        public clsSupplier setUpdatedAt(DateTime updatedAt)
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
        public static clsSupplier SelectById(int id)
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

            clsSupplier supp = new clsSupplier();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                supp.setId(Convert.ToInt32(dr["id"]));
                supp.setName(dr["name"].ToString());
                supp.setAddress(dr["address"].ToString());
                supp.setPhoneNumber(dr["phone_number"].ToString());
                supp.setZipCode(dr["zip_code"].ToString());
                supp.setEmail(dr["email"].ToString());
                supp.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                supp.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return supp;
            }

            return null;
        }
        public void Insert()
        {
            string insertString = String.Concat("INSERT INTO ", tableName, " (email, name, address, zip_code, phone_number, created_at, updated_at)", " VALUES (@email, @name, @address, @zipCode, @phoneNumber, @createdAt, @updatedAt)");

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertString, clsDatabase.conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@zipCode", zipCode);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
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
            string updateString = String.Concat("UPDATE ", tableName, " SET email = @email, name = @name, address = @address, zip_code = @zipCode, ", "phone_number = @phoneNumber, updated_at = @updatedAt WHERE ID = @id");

            MySqlCommand cmd;
            cmd = new MySqlCommand(updateString, clsDatabase.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@zipCode", zipCode);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
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
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE ID = @id");

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
