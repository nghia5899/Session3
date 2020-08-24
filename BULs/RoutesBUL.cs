using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class RoutesBUL
    {
        RoutesDAL routesDAL = new RoutesDAL();
        SanBayDAL sanBayDAL = new SanBayDAL();

        public List<RoutesDTO>  getRoutes(SanBayDTO from, SanBayDTO to, String ngaydi, Double hangve)
        {
            return routesDAL.getRoutes(from, to, ngaydi, hangve);
        }

        public List<RoutesDTO> xulychuyenbay(SanBayDTO from,SanBayDTO to, String ngaydi, Double hangve)
        {
            List<RoutesDTO> list1 = routesDAL.getRoutesFrom(from,ngaydi,hangve);
            List<RoutesDTO> list2 = routesDAL.getRoutesTo(to,ngaydi,hangve);
            List<RoutesDTO> listtong = new List<RoutesDTO>();
            List<RoutesDTO> listbaythang = routesDAL.getRoutes(from, to, ngaydi, hangve);
            foreach (RoutesDTO item in listbaythang)
            {
                listtong.Add(item);
            }
            if (list1.Count > 0 && list2.Count>0)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    for (int j = 0; j < list2.Count; j++)
                        if (list1[i].To == list2[j].From && String.Compare(list1[i].Time, list2[j].Time,true)<0)
                        {
                            RoutesDTO routesDTO = new RoutesDTO();
                            routesDTO.From = sanBayDAL.getSanBayWithId(from.Id).Iatacode;
                            routesDTO.To = sanBayDAL.getSanBayWithId(to.Id).Iatacode;
                            routesDTO.Flights_number = list1[i].Flights_number + list2[j].Flights_number;
                            routesDTO.Cabin_price = (Double.Parse(list1[i].Cabin_price) + Double.Parse(list2[j].Cabin_price)).ToString();
                            routesDTO.Number_of_stops++;
                            routesDTO.Idschedules = list1[i].Idschedules + "-" + list2[j].Idschedules;
                            routesDTO.Date = list1[i].Date;
                            routesDTO.Time = list1[i].Time;
                            listtong.Add(routesDTO);
                        }
                }
            }
            return listtong;
           
        }

    }
}
