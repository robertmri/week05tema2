using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }

        DateTime StartDate { get; }
        int MonthsOfContract { get; }
        decimal InterestRate { get; set; }

        decimal CalculateInterest();
    }

}
