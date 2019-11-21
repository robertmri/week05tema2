using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface IStore
    {
        IOrder Order { get; }
        string StoreName { get; }
        void PlaceOrder(IOrder order);
        void CancelOrder(IOrder order);

    }
}
