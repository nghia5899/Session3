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
            List<RoutesDTO> list2 = new List<RoutesDTO>();
            
            //list ngày hiện tại
            List<RoutesDTO> list21 = routesDAL.getRoutesTo(to, ngaydi, hangve);
            List<RoutesDTO> listtong = new List<RoutesDTO>();
            List<RoutesDTO> listbaythang = routesDAL.getRoutes(from, to, ngaydi, hangve);
            foreach (RoutesDTO item in listbaythang)
            {
                listtong.Add(item);
            }
            
                for (int i = 0; i < list1.Count; i++)
                {
                    int thoigianbay = list1[i].Flighttime;
                    DateTime NgayDi = DateTime.Parse(ngaydi+" "+ list1[i].Time);
                    int ngay = NgayDi.Day;
                    NgayDi  = NgayDi.AddMinutes(thoigianbay+120);
                    //list của ngày mới
                    List<RoutesDTO> list22 = routesDAL.getRoutesTo(to, NgayDi.ToString("yyyy/MM/dd"), hangve);
                    if (ngay == NgayDi.Day)
                        list2.AddRange(list21);
                    else
                        list2.AddRange(list22);
                    for (int j = 0; j < list2.Count; j++)
                        if(ngay==NgayDi.Day)
                        {
                            DateTime tg1 = DateTime.Parse(list1[i].Time).AddMinutes(thoigianbay);
                            DateTime tg2 = DateTime.Parse(list2[j].Time);
                            if (list1[i].To == list2[j].From && tg1.CompareTo(tg2) < 0)
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
                        else
                            if (list1[i].To == list2[j].From)
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
            
            return listtong;
           
        }
        public void addRoutes()
        { 
            
        }

    }
}
