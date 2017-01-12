using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Dapper;

namespace T4Template
{
    class MySqlTemplate
    {
        public void Temp()
        {
            string connStr = ConfigurationManager.ConnectionStrings["mysqlConn"].ConnectionString;
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                IList<Listing> result = conn.Query<Listing>("SELECT * FROM listing LIMIT 1,10").ToList<Listing>();

                Listing newListing = new Listing();
                newListing.address = "abcdef ghijk";
                newListing.name = "testing testing";
                newListing.postal = "123456";
                SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
                int ret = conn.Insert<int>(newListing);

                conn.Close();
            }
                
            
        }
    }
}
