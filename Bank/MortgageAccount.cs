using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class MortgageAccount : Account
    {
        public MortgageAccount(TheBank bank, Customer customer, decimal balance, decimal iRate, int mOfContract)
            : base(bank, customer, balance, iRate, mOfContract) { }

        public override decimal CalculateInterest()
        {
            decimal calculatedInterest = 0;
            if (this.Customer.GetType() == typeof(Individual))
            {
                calculatedInterest = this.Balance * ((this.MonthsOfContract - 6) * this.interestRate);
            }
            if (this.Customer.GetType() == typeof(Company))
            {
                if (this.MonthsOfContract < 12 && this.MonthsOfContract > 0)
                {
                    calculatedInterest = (this.Balance * (this.MonthsOfContract * this.interestRate) / 2);

                }
                else
                {
                    calculatedInterest = (this.Balance * (12 * this.interestRate) / 2);
                    calculatedInterest += this.Balance * ((this.MonthsOfContract - 12) * this.interestRate);
                }

            }
            return Math.Round(calculatedInterest, 2);
        }

    }
}
