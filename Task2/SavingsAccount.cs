namespace Task2
{
    public class SavingsAccount
    {
        private decimal savingsBalance;
        // private static float annualIntRate;


        public SavingsAccount(decimal initialBalance, float interestRate = 0.04F)
        {
            SavingsBalance = initialBalance;
            AnnualIntRate = interestRate;
            
        }
        private static float annualIntRate;
        private static float AnnualIntRate
        {
            get { return annualIntRate; }
            set { 
                    if(value > 0)
                    {
                    annualIntRate = value; 
                    }
                }
        }
        
        public decimal SavingsBalance
        {
            get { return savingsBalance; }
            set { 
                if(value > 0){
                savingsBalance = value; 
                }
                }
        }
        
        public void CalculateMonthlyInterest(){
            decimal interest = (SavingsBalance * (decimal)(annualIntRate)) /12;
            SavingsBalance += interest;
        }

        public static void ModifyInterestRate(float newIntRate){
            if(newIntRate > 0){
                annualIntRate =newIntRate;
            }
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"Total on savings account is {SavingsBalance}";
        }
    }
}