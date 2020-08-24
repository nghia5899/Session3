using DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class SeatDAL
    {
        SqlConnection con;
        public SeatDAL()
        {
            con = SqlConnect.conect();
        }
        public int getSeatType(String id,String type)
        {
            int soghe=0;
            con.Open();
            String sqlselect = "select count(*) as soghe from tickets where ScheduleID = @id and CabinTypeID = @type";
            
            SqlCommand cmd = new SqlCommand(sqlselect, con);    
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("type", type);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            soghe = Convert.ToInt32(dr["soghe"]);
            con.Close();
            return soghe;
        }
        public SeatDTO getSeat(String id)
        {
            
            con.Open();
            String sqlselect = "select Aircrafts.EconomySeats,Aircrafts.BusinessSeats,Aircrafts.TotalSeats " +
                " from Schedules inner join Aircrafts on Schedules.AircraftID = Aircrafts.id" +
                " where Schedules.ID = @id ";

            SqlCommand cmd = new SqlCommand(sqlselect, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            SeatDTO seat = new SeatDTO(Convert.ToInt32(dr["economyseats"]),
                Convert.ToInt32(dr["businessseats"]));
            seat.Firstclass = Convert.ToInt32(dr["totalseats"]) - seat.Economyseat - seat.Businessseat ;
            con.Close();
            return seat;

        }
    }
}
