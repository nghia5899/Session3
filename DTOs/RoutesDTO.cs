using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class RoutesDTO
    {
        String from;
        String to;
        String date;
        String time;
        String flights_number;
        String cabin_price;
        int number_of_stops;

        public RoutesDTO(){}
        public RoutesDTO(String from, String to, String date, String time, String flights_number, String cabin_price, int number_of_stops)
        {
            this.From = from;
            this.To = to;
            this.Date = date;
            this.Time = time;
            this.Flights_number = flights_number;
            this.Cabin_price = cabin_price;
            this.Number_of_stops = number_of_stops;
        }

        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Flights_number { get => flights_number; set => flights_number = value; }
        public string Cabin_price { get => cabin_price; set => cabin_price = value; }
        public int Number_of_stops { get => number_of_stops; set => number_of_stops = value; }
    }
}
