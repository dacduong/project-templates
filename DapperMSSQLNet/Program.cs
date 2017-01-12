using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TPDotnet.AP.BI.Pos;
using TPDotnet.Base.DatabaseEnvironment;

using Dapper;

namespace SimplePoco
{
    class Program
    {
        static void Main(string[] args)
        {

            //using predefine connection string in App.config
            using (IDbConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConn"].ConnectionString))
            {
                if (myConn.State == ConnectionState.Closed)
                    myConn.Open();
                List<Item> items =  myConn.Query<Item>("Select * From Item").ToList<Item>();
                string tmpColumn = Item.bDiscountFlagColumnName;
                Console.WriteLine(tmpColumn);
                List<Computer> computers = myConn.Query<Computer>("Select * From Computer").ToList<Computer>();
                List<RetailStore> retailstores = myConn.Query<RetailStore>("Select * From RetailStore").ToList<RetailStore>();
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }

            //using TPDotnet API
            TPDatabaseConnect db = TPDatabaseConnect.GetInstance("TPPosDB");
            IDbConnection conn = db.GetConnection();
            List<Computer> xxx = conn.Query<Computer>("Select * From Computer").ToList<Computer>();

            Console.ReadKey();
            
        }
    }
}
