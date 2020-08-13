using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class SqlConnect
    {
        
        public static SqlConnection conect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-55OS1IN\SQLEXPRESS;Initial Catalog=Session3;Integrated Security=True");
            return con;
        }
        
    
    }
}
