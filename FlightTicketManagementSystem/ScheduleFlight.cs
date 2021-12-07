using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightTicketManagementSystem.Model;

namespace FlightTicketManagementSystem
{
    public class ScheduleFlight : FlightInfo
    {
        public int capacity;
        public List<int> seats;
        public Dictionary<int, PassengerInfo> Passengers = new Dictionary<int, PassengerInfo>();
        public ScheduleFlight(string AirName, string FN, string Start, string Des, DateTime DT, DateTime AT, float p, int Cap, float prc) 
            : base(AirName, FN, Start, Des, DT, AT, p)
        {
            capacity = Cap;
            Price = prc;
            seats = Enumerable.Range(1, capacity).ToList();
        }

        public void AddPassenger(int seatNumber)
        {
            FrmAddPassenger frm = new FrmAddPassenger();
            frm.capacity = capacity;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.txtSeatNumber.Text = seatNumber.ToString();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string passengerName = frm.txtPassengerName.Text.Trim();
                string passengerEmail = frm.txtPassengerEmail.Text.Trim();
                string lugguageType = frm.txtLugguageType.Text.Trim();
                int passengerType = frm.chkVip.Checked ? 1 : 0;

                if (passengerType == 0)
                {
                    Passengers.Add(seatNumber, new PassengerInfo(passengerName, seatNumber, passengerEmail, lugguageType));
                }
                else
                {
                    VipPassengerInfo VIP = new VipPassengerInfo(passengerName, seatNumber, passengerEmail, lugguageType);
                    while (MessageBox.Show("More services to Add?", "Question", MessageBoxButtons.YesNo) ==
                           DialogResult.Yes)
                    {
                        FrmAddService frmService = new FrmAddService();
                        frmService.StartPosition = FormStartPosition.CenterParent;
                        if (frmService.ShowDialog() == DialogResult.OK)
                        {
                            string name = frmService.txtServiceName.Text.Trim();
                            float price = (float)frmService.numPrice.Value;
                            float discount = (float) frmService.numDiscount.Value;
                            VIP.AddService(name, price, discount);
                        }
                    }

                    Passengers.Add(seatNumber, VIP);
                }

                if (MessageBox.Show("Continue to Checkout?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Total BookFlight Price : " + MemoryData.Bag.GetTotalPrice());
                }
            }
        }

        public void RemovePassenger(int passengerSeat)
        {
            Passengers.Remove(passengerSeat);
        }

        public float GetCurrentPrice()
        {
            return Price;
        }

        public bool HaveFlightOccupancy()
        {
            if (Passengers.Count == capacity)
            {
                return false;
            }
            return true;
        }

        public PassengerInfo GetLastPassenger()
        {
            return Passengers.Values.Last();
        }

        public override string ToString()
        {
            return "Flight Name: " + FlightName + "   Start Point: " + StartPosition + "   Distination: " + Destination + "   Departure Time: " + DepartureTime + "  Arrival Time: " + ArrivalTime + "  #Passengers" + Passengers.Count;
        }

        public List<int> ListofFreePlaces()
        {
            if (Passengers.Count == 0)
            {
                return seats;
            }

            foreach (PassengerInfo p in Passengers.Values)
            {
                seats.Remove(p.SeatNo);
            }
            return seats;
        }
    }
}
