using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface IProducer
    {
        CarProducer ProducerName { get; }
        string AllDetails { get; }
    }
    public enum CarProducer
    {
        Ford,
        Volkswagen,
        BMW
    }
}
