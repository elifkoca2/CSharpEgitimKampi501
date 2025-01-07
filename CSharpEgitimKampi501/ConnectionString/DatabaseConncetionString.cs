using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.ConnectionString
{
    public static class DatabaseConncetionString
    {
        public static void SQLDatabaseConncetionString()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-CL0PR4G;initial Catalog=EgitimKampi501Db;integrated security;true");
        }
    }
}
