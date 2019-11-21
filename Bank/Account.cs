using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal abstract class Account : IAccount
    {
        public Account(TheBank bank, Customer customer, decimal balance, decimal iRate, int mOfContract)
        {
            this.BankName = bank;
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = iRate;
            this.interestRate = this.InterestRate / 100;
            this.StartDate = DateTime.Now;
            this.MonthsOfContract = mOfContract;
            accountNumber++;
        }
        protected static int accountNumber = 0;
        public Customer Customer { get; }

        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; set; }
        internal decimal interestRate;

        public DateTime StartDate { get; }

        public int MonthsOfContract { get; }

        public abstract decimal CalculateInterest();

        public TheBank BankName { get; set; }
        internal void Deposit(decimal deposit)
        {
            this.Balance = this.Balance + deposit;
        }
    }

}
