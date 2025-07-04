using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management_System.Models
{
    public class SqlDbDataAccess
    {
        private const string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=Connection; Integrated Security=True;";

        public SqlCommand GetQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
