using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var saver1 = new SavingsAccount();

            SavingsAccount saver1 = new SavingsAccount(2000M);
            SavingsAccount saver2 = new SavingsAccount(3000M);


            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            Console.WriteLine($"saver1 savings balance is {saver1.SavingsBalance:C}");
            Console.WriteLine($"saver2 savings balance is {saver2.SavingsBalance:C}");

            SavingsAccount.ModifyInterestRate(0.05F);

            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            Console.WriteLine("\nNew balances after modifying annual interst rate is 5%");

            Console.WriteLine($"saver1 savings balance is {saver1.SavingsBalance:C}");
            Console.WriteLine($"saver2 savings balance is {saver2.SavingsBalance:C}");
        }
    }
}
