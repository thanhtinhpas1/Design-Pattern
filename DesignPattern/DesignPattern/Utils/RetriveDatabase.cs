using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Utils
{
    class RetriveDatabase
    {
        void GenModel(SqlConnection conn)
        {
            if (conn == null) return;
            // Get the schema information of Databases in your instance
            DataTable schema = conn.GetSchema("Databases");

            // First, get schema information of all the tables in current database;  
            DataTable allTablesSchemaTable = conn.GetSchema("Tables");

            foreach(var table in allTablesSchemaTable.Columns)
            {
                // TODO: gen model with fiel as col here
            }
        }
    }
}
