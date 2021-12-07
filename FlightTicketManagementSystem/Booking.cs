using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlightTicketManagementSystem.Model;

namespace FlightTicketManagementSystem
{
    public class BookFlight
    {
        static int BookFlightId = 0;
        ScheduleFlight F1;
        public BookFlight(ScheduleFlight f)
        {
            BookFlightId++;
            F1 = f;
        }

        public void BookFlightRecord(int seatNumber)
        {
            F1.AddPassenger(seatNumber);
        }

        public float GetTotalPrice()
        {
            if (F1.GetLastPassenger() is VipPassengerInfo)
            {
                return F1.GetCurrentPrice() + ((VipPassengerInfo)F1.GetLastPassenger()).ServicesPrice();
            }

            return F1.GetCurrentPrice();
        }
    }
}
