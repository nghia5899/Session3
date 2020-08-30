using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class SeatBUL
    {
        SeatDAL seatDAL = new SeatDAL();

        public String checkSeat(String id, String type,int sove)
        {
            SeatDTO seatDTO = seatDAL.getSeat(id);
            int soghe = seatDAL.getSeatType(id, type);
            String tinhtrang = "EconomySeats:" + seatDAL.getSeatType(id, "1") + "/" + seatDTO.Economyseat+
                                "\n BusinessSeats:" + seatDAL.getSeatType(id, "2") + "/" + seatDTO.Businessseat+
                                "\n FirstClassSeats:" + seatDAL.getSeatType(id, "3") + "/" + seatDTO.Firstclass;
            if (type == "1")
                if (soghe+sove <= seatDTO.Economyseat)
                    return "1";
                else
                    return tinhtrang;
            if (type == "2")
                if (soghe+sove <= seatDTO.Businessseat)
                    return "1";
                else
                    return tinhtrang;
            if (type == "3")
                if (soghe+sove <= seatDTO.Firstclass)
                    return "1";
                else
                    return tinhtrang;

            return tinhtrang;
        }

        
            

    }
}
