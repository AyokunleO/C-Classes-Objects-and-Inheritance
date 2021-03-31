namespace Task2
{
    public class SavingsAccount
    {
        private double savingsBalance;
        private static double annualIntRate =0.04;


        public SavingsAccount(double savings)
        {
            SavingsBalance = savings;
            
        }
        public double SavingsBalance
        {
            get { return savingsBalance; }
            set { savingsBalance = value + CalculateMonthlyInterest(value); }
        }
        
        private double CalculateMonthlyInterest(double value){
            return value * (annualIntRate/12);
        }

        public static void ModifyInterestRate(double rate){
                annualIntRate =rate/100;
        }
        public override string ToString()
        {
            // return base.ToString();
            return $"Total on savings account is {SavingsBalance}";
        }
    }
}