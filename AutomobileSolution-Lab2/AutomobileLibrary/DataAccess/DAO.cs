using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace AutomobileLibrary.DataAccess
{
    public class DAO
    {
        private static DAO instance;
        public static DAO Instance
        {
            get { if (instance == null) instance = new DAO(); return instance; }
            set { instance = value; }
        }

        public DAO()
        {

        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(DBContext.GetConnectionString());

        }
        public DataTable GetDataBySql(String sql)
        {
            SqlConnection conn = GetConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetDataBySql(string sql, SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnection();
            try
            {
                //1. create cmd (sql, connection)
                SqlCommand cmd = new SqlCommand(sql, conn);
                // 2. add parameters
                cmd.Parameters.AddRange(parameters);
                // 3. add cmd to adapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // 4. add data from adapter to datatable
                DataTable result = new DataTable();
                adapter.Fill(result);
                conn.Close();
                return result;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            finally { conn.Close(); }
        }

    }
}
