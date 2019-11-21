using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class DepositAccount : Account, IWithdrawableAccount
    {
        public DepositAccount(TheBank bank, Customer customer, decimal balance, decimal iRate, int mOfContract)
            : base(bank, customer, balance, iRate, mOfContract) { }
        public override decimal CalculateInterest()
        {
            decimal calculatedInterest = 0;
            if (0 < this.Balance && this.Balance < 1000)
            {
                calculatedInterest = 0;
            }

            else
            {
                calculatedInterest = this.Balance * (this.MonthsOfContract * this.interestRate);
            }

            return Math.Round(calculatedInterest, 2);
        }
        public void Withdraw(decimal withdraw)
        {
            this.Balance = Balance - withdraw;
        }
    }
}
