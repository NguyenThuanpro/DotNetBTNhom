using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BTapNhom
{
    internal class ConnectDatabase
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;
        public void ConnectToDatabase()
        {
            string sql1 = ConfigurationManager.ConnectionStrings["QLHS_DB"].ConnectionString;
            cnn = new SqlConnection(sql1);
            cnn.Open();
        }

        public void CloseConnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public DataTable GetData(string sql)
        {
            ConnectToDatabase();
            dta = new DataTable();
            ada = new SqlDataAdapter(sql, cnn);
            ada.Fill(dta);
            CloseConnection();
            return dta;
        }

        public void Execute(string sql)
        {
            ConnectToDatabase();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
