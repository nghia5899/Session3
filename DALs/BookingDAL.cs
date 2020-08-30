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
    public class BookingDAL
    {
        SqlConnection con;
        public BookingDAL()
        {
            con = SqlConnect.conect();
        }
        public RoutesDTO getRoutes(String id,Double hangve)
        {
            con.Open();
            RoutesDTO routes ;
            string sqlSelect = "select Schedules.ID, Routes.DepartureAirportID,Routes.ArrivalAirportID, Schedules.Date,Schedules.Time ,Schedules.FlightNumber,Schedules.EconomyPrice"+
                " from Routes inner join Schedules on Routes.ID = Schedules.RouteID inner"+
                " join Aircrafts on Schedules.AircraftID = Aircrafts.ID"+
                " where Schedules.ID = @id";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            routes = new RoutesDTO(dr["DepartureAirportID"].ToString(),
                   dr["ArrivalAirportID"].ToString(),
                   String.Format("{0:yyyy/MM/dd}",dr["date"].ToString()),
                   dr["Time"].ToString(),
                   "[" + dr["FlightNumber"].ToString() + "]",
                   Math.Round((Convert.ToDouble(dr["EconomyPrice"]) * hangve)).ToString(),
                   0);
            DateTime date = DateTime.Parse(String.Format("{0:yyyy/MM/dd}", dr["date"].ToString()));
            routes.Date = date.ToString("yyyy/MM/dd");
                routes.Idschedules = dr["ID"].ToString();
            con.Close();


            return routes;
        }
        public DataTable getCountry()
        {
            con.Open();
            DataTable tb = new DataTable();
            String sqlSelect = "select * from countries";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            con.Close();
            return tb;
        }
    }
}
