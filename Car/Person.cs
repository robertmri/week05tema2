using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Person : IPerson
    {
        public Person(string name)
        {
            this.PersonName = name;
        }
        public string PersonName { get; }

        public void VisitShowroom(IStore store)
        {
            Console.WriteLine($"{this.PersonName} visited {store.StoreName}");
        }
    }
}
