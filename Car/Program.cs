using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var alex = new Person("Alex");


            Producer bmw = new Producer(CarProducer.BMW);
            Producer ford = new Producer(CarProducer.Ford);
            Producer volkswagen = new Producer(CarProducer.Volkswagen);

            Vehicle bmvX1 = new Vehicle(bmw, "M6", 2012, 25000);
            Vehicle fordFiesta = new Vehicle(ford, "Fiesta", 2017, 15000);
            Vehicle skodaOctavia = new Vehicle(volkswagen, "Passat", 2015, 16000);


            Store bmwStore = new Store(bmw);
            Store fordStore = new Store(ford);
            Store volkswagenStore = new Store(volkswagen);

            alex.VisitShowroom(fordStore);
            Order fordOrder = new Order(fordFiesta, 4, alex);
            fordStore.PlaceOrder(fordOrder);

            alex.VisitShowroom(volkswagenStore);
            Order volkswagenOrder = new Order(volkswagenPassat, 3, alex);
            volkswagenStore.PlaceOrder(volkswagenOrder);

            fordStore.CancelOrder(fordOrder);

            ///// after  weeks

            volkswagenOrder.OrderDelivered();
        }
    }
    }
}
