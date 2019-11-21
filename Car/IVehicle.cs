using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface IVehicle
    {
        IProducer Producer { get; }
        string ModelName { get; }
        int FabYear { get; }
        int Price { get; }
        string AllDetails { get; }
    }
}
