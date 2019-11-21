using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class LoanAccount : Account
    {
        public LoanAccount(TheBank bank, Customer customer, decimal balance, decimal iRate, int mOfContract)
            : base(bank, customer, balance, iRate, mOfContract) { }

        public override decimal CalculateInterest()
        {
            decimal calculatedInterest = 0;
            if (this.Customer.GetType() == typeof(Individual))
            {
                calculatedInterest = this.Balance * ((this.MonthsOfContract - 3) * this.interestRate);
            }
            if (this.Customer.GetType() == typeof(Company))
            {
                calculatedInterest = this.Balance * ((this.MonthsOfContract - 2) * this.interestRate);
            }
            return Math.Round(calculatedInterest, 2);
        }

    }
}
