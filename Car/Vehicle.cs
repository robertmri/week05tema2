using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Vehicle : IVehicle
    {
        public Vehicle(IProducer producer, string model, int year, int price)
        {
            this.Producer = producer;
            if (producer.ProducerName == CarProducer.Ford && Enum.IsDefined(typeof(FordModel), model))
            {
                this.ModelName = model;
            }
            else
            if (producer.ProducerName == CarProducer.Volkswagen && Enum.IsDefined(typeof(VolkswagenModel), model))
            {
                this.ModelName = model;
            }
            else
            if (producer.ProducerName == CarProducer.BMW && Enum.IsDefined(typeof(BMWModel), model))
            {
                this.ModelName = model;
            }
            else
            {
                Console.WriteLine("Sorry, this model is not available in our list");
            }

            this.FabYear = year;
            this.Price = price;
        }
        public IProducer Producer { get; }
        public string ModelName { get; }
        public int FabYear { get; }
        public int Price { get; }
        public string AllDetails
        {
            get
            {
                return $"Producer: {Producer.AllDetails}, Model: [{ this.ModelName}] " +
                    $"Fabrication year: [{ this.FabYear}], Price: [{this.Price}]";
            }
        }
    }

    public enum FordModel
    {
        Focus,
        Fiesta
    }

    public enum VolkswagenModel
    {
        Passat,
        CC
    }

    public enum BMWModel
    {
        M6,
        M3
    }
}
