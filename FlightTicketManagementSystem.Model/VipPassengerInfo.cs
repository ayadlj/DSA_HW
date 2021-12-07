using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightTicketManagementSystem.Model
{
    public class VipPassengerInfo : PassengerInfo
    {
        private List<Services> services = new List<Services>();

        public VipPassengerInfo(string nm, int cntct, string emal, string luggage) : base(nm, cntct, emal, luggage) { }

        public void AddService(string name, float price, float discount)
        {
            services.Add(new Services(name, price, discount));
        }

        public void RemoveService(string name)
        {
            foreach (Services aPart in services)
            {
                if (aPart.GetServiceName() == name)
                {
                    services.Remove(aPart);
                }
            }
        }

        public void ShowAvaildServices()
        {
            foreach (Services aPart in services)
            {
                Console.WriteLine(aPart);
            }
        }

        public float ServicesPrice()
        {
            float total = 0;
            foreach (Services sv in services)
            {
                if (sv.GetDiscount() > 0)
                {
                    sv.ApplyDiscount();
                }
                total = total + sv.GetPrice();
            }
            return total;
        }
    }
}
