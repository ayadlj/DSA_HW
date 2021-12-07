using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightTicketManagementSystem
{
    public class Schedule
    {
        public List<ScheduleFlight> ScheduleFlightList = new List<ScheduleFlight>();
        public Dictionary<int, ScheduleFlight> AvailScheduleFilghts = new Dictionary<int, ScheduleFlight>();
        
        public void ShowAvailableFlights()
        {
            int count = 1;
            AvailScheduleFilghts.Clear();
            foreach (ScheduleFlight sf in ScheduleFlightList)
            {
                if (sf.HaveFlightOccupancy())
                {
                    AvailScheduleFilghts.Add(count, sf);
                    count++;
                }
            }
        }

        public ScheduleFlight GetFlight(int index)
        {
            return ScheduleFlightList[index];
        }
    }
}
