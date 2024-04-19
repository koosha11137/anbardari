using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace anbar
{
    class database
    {
                private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataAdapter da;
        private DataTable dt ; 

        public void DoCommand(string ole)
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.strcon;
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ole;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable MySelect(string sql)
        {
            con = new SqlConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb;Persist Security Info=True;";
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            con.Open();
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        internal void MySelect(string p, SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}

namespace anbar
{
    public class DataBase
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataAdapter  da;
        private DataTable dt; 
        public DataBase()
        {
        }

        public void DoCommand(string ole)
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.strcon;
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ole;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable MySelect(string sql)
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.strcon;
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            con.Open();
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}