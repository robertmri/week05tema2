using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Store : IStore
    {
        public Store(Producer producer)
        {
            this.StoreName = producer.ProducerName.ToString();
            OrderList = new List<IOrder>();
            VehicleList = new List<Vehicle>();


        }
        public IOrder Order { get; }
        private List<IOrder> OrderList { get; }
        private List<Vehicle> VehicleList { get; }
        public string StoreName { get; }

        public string AllDetails
        {
            get
            {
                return $"Store: {this.StoreName} show room";
            }
        }

        public void CancelOrder(IOrder order)
        {
            OrderList.Remove(order);
            Console.WriteLine($"Following order was removed:\n {order.AllDetails}");
        }

        public void PlaceOrder(IOrder order)
        {
            if (this.StoreName == order.Vehicle.Producer.ProducerName.ToString())
            {
                OrderList.Add(order);
                Console.WriteLine($"Following order was placed:\n {order.AllDetails}");
            }
            else
            {
                Console.WriteLine("Sorry, can not place order in this store.");
            }

        }
        public void AddVehile(Vehicle v)
        {
            if (this.StoreName == v.Producer.ToString())
            {
                VehicleList.Add(v);
            }
            else
            {
                Console.WriteLine("Sory, car model is either not matching the car producer or is not available");
            }
        }
    }
}
