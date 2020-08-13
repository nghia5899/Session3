using DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class RoutesDAL
    {
        SqlConnection con;
        public RoutesDAL()
        {
            con = SqlConnect.conect();
        }

        public List<RoutesDTO> getRoutes(SanBayDTO from,SanBayDTO to,String ngaydi,Double hangve)
        {
            con.Open();
            List<RoutesDTO> danhsach = new List<RoutesDTO>();

            string sqlSelect = "select Schedules.Date,Schedules.Time ,Schedules.FlightNumber,Schedules.EconomyPrice " +
                "from Routes inner join Schedules on Routes.ID = Schedules.RouteID inner " +
                "join Aircrafts on Schedules.AircraftID = Aircrafts.ID " +
                "where DepartureAirportID = @mafrom and ArrivalAirportID = @mato and Schedules.Date = @ngaydi";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            cmd.Parameters.AddWithValue("mafrom", from.Id);
            cmd.Parameters.AddWithValue("mato", to.Id);
            cmd.Parameters.AddWithValue("ngaydi", ngaydi);  
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RoutesDTO routesDTO = new RoutesDTO(from.Iatacode,
                    to.Iatacode,
                    ngaydi,
                   dr["Time"].ToString(),
                   "[" + dr["FlightNumber"].ToString() + "]",
                   (Convert.ToDouble(dr["EconomyPrice"])*hangve).ToString(),
                  0 );

                danhsach.Add(routesDTO);
            }
            con.Close();
            return danhsach;
        }

        public List<RoutesDTO> getRoutesFrom(SanBayDTO from, String ngaydi, Double hangve)
        {
            con.Open();
            List<RoutesDTO> danhsach = new List<RoutesDTO>();
            string sqlSelect = "select Routes.DepartureAirportID,Routes.ArrivalAirportID, Schedules.Date,Schedules.Time ,Schedules.FlightNumber,Schedules.EconomyPrice " +
                "from Routes inner join Schedules on Routes.ID = Schedules.RouteID inner " +
                "join Aircrafts on Schedules.AircraftID = Aircrafts.ID " +
                "where DepartureAirportID = @mafrom  and Schedules.Date = @ngaydi";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            cmd.Parameters.AddWithValue("mafrom", from.Id);            
            cmd.Parameters.AddWithValue("ngaydi", ngaydi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RoutesDTO routesDTO = new RoutesDTO(dr["DepartureAirportID"].ToString(),
                    dr["ArrivalAirportID"].ToString(),
                    ngaydi,
                   dr["Time"].ToString(),
                   "[" + dr["FlightNumber"].ToString() + "]",
                   (Convert.ToDouble(dr["EconomyPrice"]) * hangve).ToString(),
                   0);
                danhsach.Add(routesDTO);
            }
            con.Close();
            return danhsach;
        }
        public List<RoutesDTO> getRoutesTo(SanBayDTO to, String ngaydi, Double hangve)
        {
            con.Open();
            List<RoutesDTO> danhsach = new List<RoutesDTO>();
            string sqlSelect = "select Routes.DepartureAirportID,Routes.ArrivalAirportID, Schedules.Date,Schedules.Time ,Schedules.FlightNumber,Schedules.EconomyPrice " +
                "from Routes inner join Schedules on Routes.ID = Schedules.RouteID inner " +
                "join Aircrafts on Schedules.AircraftID = Aircrafts.ID " +
                "where ArrivalAirportID = @mato  and Schedules.Date = @ngaydi";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            cmd.Parameters.AddWithValue("mato", to.Id);
            cmd.Parameters.AddWithValue("ngaydi", ngaydi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RoutesDTO routesDTO = new RoutesDTO(dr["DepartureAirportID"].ToString(),
                    dr["ArrivalAirportID"].ToString(),
                    ngaydi,
                   dr["Time"].ToString(),
                   "[" + dr["FlightNumber"].ToString() + "]",
                   (Convert.ToDouble(dr["EconomyPrice"]) * hangve).ToString(),
                   0);
                danhsach.Add(routesDTO);
            }
            con.Close();
            return danhsach;
        }
    }
}
