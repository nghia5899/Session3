using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class TicketBUL
    {
        TicketDAL ticketDAL = new TicketDAL();

        public void addUser()
        {
            
        }
        public void addTicket(PassengerDTO passenger, String scheduleid, String cabintype, String bookingreference)
        {
            ticketDAL.addTicket(passenger,scheduleid,cabintype,bookingreference);
        }
    }
}
