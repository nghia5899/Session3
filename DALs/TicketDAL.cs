using DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class TicketDAL
    {
        SqlConnection con;
        public TicketDAL()
        {
            con = SqlConnect.conect();
        }

        public void addUser(PassengerDTO passenger)
        {
            con.Open();
            String sqlinsert = "insert into user  values(@rolesid,)";
            SqlCommand cmd = new SqlCommand(sqlinsert,con);


        }

        public void addTicket(PassengerDTO passenger,String scheduleid,String cabintype,String bookingreference)
        {
            con.Open();
            String sqlinsert = "insert into Tickets (UserID,ScheduleID,CabinTypeID,Firstname,Lastname,Phone,PassportNumber,PassportCountryID,BookingReference)" +
                                "  values(@userid,@scheduleid,@cabintypeid,@firstname" +
                                ",@lastname,@phone,@passportnumber,@passportcountry,@bookingreference)";
            SqlCommand cmd = new SqlCommand(sqlinsert, con);
            cmd.Parameters.AddWithValue("userid", 8);
            cmd.Parameters.AddWithValue("scheduleid", scheduleid );
            cmd.Parameters.AddWithValue("cabintypeid", cabintype);
            cmd.Parameters.AddWithValue("firstname", passenger.Firstname);
            cmd.Parameters.AddWithValue("lastname", passenger.Lastname);
            cmd.Parameters.AddWithValue("phone", passenger.Phone);
            cmd.Parameters.AddWithValue("passportnumber", passenger.Passportnumber);
            cmd.Parameters.AddWithValue("passportcountry", passenger.PassportcountryId);
            cmd.Parameters.AddWithValue("bookingreference", bookingreference);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
