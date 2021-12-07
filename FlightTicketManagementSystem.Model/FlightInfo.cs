using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightTicketManagementSystem.Model
{
    public class FlightInfo
    {
        public string AirLine { get; set; }

        public string FlightName { get; set; }

        public string StartPosition { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public float Price { get; set; }

        public FlightInfo(string AirName, string FlN, string Start, string Des, DateTime DT, DateTime AT, float p)
        {
            AirLine = AirName;
            FlightName = FlN;
            StartPosition = Start;
            Destination = Des;
            DepartureTime = DT;
            ArrivalTime = AT;
            Price = p;
        }
    }
}
