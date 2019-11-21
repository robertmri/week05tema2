using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal abstract class TheBank
    {
        protected List<Account> AccountsList;
        internal TheBank(string name)
        {
            this.AccountsList = new List<Account>();
            this.Name = name;
        }

        public string Name { get; }
    }
}
