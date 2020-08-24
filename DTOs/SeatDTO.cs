using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SeatDTO
    {
        int economyseat;
        int businessseat;
        int firstclass;

        public SeatDTO(){}
        public SeatDTO(int economy,int business,int first)
        {
            this.Economyseat = economy;
            this.Businessseat = business;
            this.Firstclass = first;
        }
        public SeatDTO(int economy, int business)
        {
            this.Economyseat = economy;
            this.Businessseat = business;
            
        }
        public int Economyseat { get => economyseat; set => economyseat = value; }
        public int Businessseat { get => businessseat; set => businessseat = value; }
        public int Firstclass { get => firstclass; set => firstclass = value; }
    }
}
