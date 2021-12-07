using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightTicketManagementSystem.Model
{
    public class Services
    {
        private float discount;
        private string serviceName;
        private float price;

        public Services(string name, float dis, float prc)
        {
            this.serviceName = name;
            this.discount = dis;
            this.price = prc;
        }

        public void ChangePrice(float p1)
        {
            price = p1;
        }

        public void ChangeDiscount(float dis)
        {
            discount = dis;
        }

        public float GetPrice()
        {
            return price;
        }

        public String GetServiceName()
        {
            return serviceName;
        }

        public float GetDiscount()
        {
            return discount;
        }

        public void ApplyDiscount()
        {
            price = (price * discount) / 100;
        }

        public override string ToString()
        {
            return "Service Name: " + serviceName + "   Price: " + Convert.ToString(price) + "   Discount: " + Convert.ToString(discount);
        }
    }
}
