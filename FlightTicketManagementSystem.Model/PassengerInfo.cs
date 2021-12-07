using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightTicketManagementSystem.Model
{
    public class PassengerInfo
    {
        public string Name { get; set; }

        public int SeatNo { get; set; }

        public string Email { get; set; }

        public string LuggageType { get; set; }

        public PassengerInfo(string name, int seatNo, string email, string luggage)
        {
            this.Name = name;
            this.SeatNo = seatNo;
            this.Email = email;
            this.LuggageType = luggage;
        }
    }
}
