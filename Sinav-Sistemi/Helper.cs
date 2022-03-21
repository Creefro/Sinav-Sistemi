using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    public static class Helper
    {
        public static SqlConnection GetConnection(string name)
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[name].ConnectionString);
        }
    }
}
