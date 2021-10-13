using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace MarketRace.DataBase
{
    public class BDAccess
    {
        public static SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["MarketRace"].ConnectionString);
            return cn;
        }
    }
}