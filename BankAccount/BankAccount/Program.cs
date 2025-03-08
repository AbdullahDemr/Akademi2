using BankAccount;

public class Program
{
    public static void Main()
    {
        
        SavingsAccount savingsAccount = new SavingsAccount
        {
            AccountHolder = "Ali",
            Balance = 1000
        };

        
        CheckingAccount checkingAccount = new CheckingAccount
        {
            AccountHolder = "Ahmet",
            Balance = 1000
        };

      
        Console.WriteLine($"{savingsAccount.AccountHolder} için faiz miktarı: {savingsAccount.CalculateInterest()}");
        checkingAccount.CalculateInterest(); 
    }
}