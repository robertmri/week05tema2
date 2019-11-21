using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Order : IOrder
    {
        public Order(IVehicle veh, int weeksDelivery, IPerson person)
        {
            this.Vehicle = veh;
            this.OrderNo = ++orderNumber;
            this.WeeksOfDelivery = weeksDelivery;
            this.Prospect = person;
        }
        public IPerson Prospect { get; }
        public IVehicle Vehicle { get; }
        public int OrderNo { get; }

        private static int orderNumber = 0;
        public int WeeksOfDelivery { get; }
        public string AllDetails
        {
            get
            {
                return $"Prospect: [{this.Prospect.PersonName}],\n Order no: [{this.OrderNo}],\n Vehicle: [{this.Vehicle.AllDetails}],\n " +
                    $"Weeks of delivery: [{this.WeeksOfDelivery}]";
            }

        }

        public void Print()
        {
            Console.WriteLine(this.AllDetails);
        }

        public void OrderDelivered()
        {
            Console.WriteLine($"Order was delivered according to the {this.WeeksOfDelivery} weeks of delivery");
        }
    }
}
