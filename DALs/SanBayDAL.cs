using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class SanBayDAL
    {
        SqlConnection con;
        public SanBayDAL() {
             con = SqlConnect.conect();
        }

        public DataTable getSanBay()
        {
            con.Open();
            DataTable tb = new DataTable();
            String sqlSelect = "select * from airports";
            SqlCommand cmd = new SqlCommand(sqlSelect,con );
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            con.Close();
            return tb;
        }
        public SanBayDTO getSanBayWithId(String ma)
        {
            
            con.Open();
            
            String sqlSelect = "select * from airports where id  = @ma ";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            cmd.Parameters.AddWithValue("ma",ma);
            SqlDataReader dr = cmd.ExecuteReader();
            

            dr.Read();

            
            SanBayDTO sanbay = new SanBayDTO(dr["id"].ToString(), dr["iatacode"].ToString());
           
            con.Close();
            return sanbay;
        }
        public DataTable getCabintypes()
        {
            con.Open();
            DataTable tb = new DataTable();
            String sqlSelect = "select * from cabintypes";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            con.Close();
            return tb;
        }
    }
}
