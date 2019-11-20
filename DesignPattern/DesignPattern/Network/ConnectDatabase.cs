using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Network
{
    class ConnectDatabase
    {
        private string connString = "Data Source=TINH-PC\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection MySqlConnect(string serverName, string username, string password)
        {
            //TODO: Prepare conn string here

            SqlConnection conn = null;
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();
            }
            return conn;
        }
    }
}
