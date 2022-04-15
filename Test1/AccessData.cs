using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Test1
{
    public class AccessData
    {
        public SqlConnection GetConnection()
        {
            string path = HttpContext.Current.Server.MapPath("App_Data/DatabaseHoa.mdf");
            return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; 
            AttachDbFilename=" + path + "; Integrated Security=True");
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public SqlDataReader ExcuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;                   
        }
        public DataTable DataTable(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}