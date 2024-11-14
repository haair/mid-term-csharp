using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp113.DAO
{
    internal class Database
    {
        static string strConn = "Data Source=.;Initial Catalog=STUDENT_MANAGEMENT1;User ID=haair;Password=12345;TrustServerCertificate=True";
        static SqlConnection? sqlConnection;
        public static SqlConnection GetInstance()
        {
            if (sqlConnection == null) { 
                sqlConnection = new SqlConnection(strConn);
                sqlConnection.Open();
                return sqlConnection;
            }
            return sqlConnection;
        }

        public static void Disconnect()
        {
            sqlConnection?.Close();
        }
        
    }
}
