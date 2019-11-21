using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Bank("ING");

            var c1 = new Individual();

            var d = new DepositAccount(b, c1, 1000, 3.85m, 12);
            Console.WriteLine(d.CalculateInterest());


            var l = new LoanAccount(b, c1, 1000, 3.5m, 12);
            Console.WriteLine(l.CalculateInterest());

            var c2 = new Company();
            var m = new MortgageAccount(b, c2, 1500, 3.8m, 36);
            Console.WriteLine(m.CalculateInterest());
        }
    }
}
