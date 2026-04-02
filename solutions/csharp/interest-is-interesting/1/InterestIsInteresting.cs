static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate = 0;
        float fBalance = (float)balance;
        if(balance < 0m){
            rate = 3.213f;
        }else if(balance>= 0m && balance< 1000m){
            rate = 0.5f;
        }else if(balance>= 1000m && balance< 5000m){
            rate = 1.621f;
        }else if(balance>=5000m){
            rate = 2.475f;
        }
        return rate;
    }

    public static decimal Interest(decimal balance)
    {
        decimal interestRate =(decimal)InterestRate(balance);
        decimal interest = balance*interestRate;
        return interest/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal annualBalance = Interest(balance)+balance;
        return annualBalance;
        
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;

        while (balance < targetBalance)
        {
        balance = AnnualBalanceUpdate(balance);
        year++;
        }

        return year;
    }
}
