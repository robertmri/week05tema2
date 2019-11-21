using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface IOrder
    {
        IVehicle Vehicle { get; }
        int OrderNo { get; }
        int WeeksOfDelivery { get; }
        IPerson Prospect { get; }
        string AllDetails { get; }

    }
}
