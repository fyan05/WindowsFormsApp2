using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Connection
    {
        private string ConnectionString = @"Data Source = FYAN\SQLEXPRESS; Initial Catalog=DB_LoginApp;Integrated Security =True;TrustServerCertificate=true";
        public SqlConnection GetConnection()
        {
            SqlConnection sqlConnection= new SqlConnection(ConnectionString);
            return sqlConnection;
        }
    }
}
