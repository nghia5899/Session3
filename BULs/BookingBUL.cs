using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class BookingBUL
    {
        SanBayDAL sanBayDAL = new SanBayDAL();
        BookingDAL bookingDAL = new BookingDAL();
        SqlConnection con;
        public BookingBUL()
        {
            con = SqlConnect.conect();
        }

        public RoutesDTO GetRoutes(String id,Double hangve)
        {
            RoutesDTO routes = bookingDAL.getRoutes(id, hangve);
            routes.From = sanBayDAL.getSanBayWithId(routes.From).Iatacode;
            routes.To = sanBayDAL.getSanBayWithId(routes.To).Iatacode;

            return routes;
        }
        public DataTable getCountries()
        {
            return bookingDAL.getCountry();
        }
    }
}
