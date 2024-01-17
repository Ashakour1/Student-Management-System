using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std_management_system
{
    internal class Connection
    {
        public static SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-66LE5BI; initial Catalog=sms; Integrated Security=true");
            conn.Open();
            return conn;

        }
    }
}
