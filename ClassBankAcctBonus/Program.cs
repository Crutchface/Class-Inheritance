// Chris Ferguson - Class & Subclass Assignment - Nov 1 2024 

namespace ClassBankAcctBonus
{
    internal class Program
    {   // Starts our program 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Adds some new accounts 
            BankAccount acct1 = new BankAccount(50, .10m);
            BankAccount acct2 = new CheckingAccount(100, .05m, 1000);
            BankAccount acct3 = new CheckingAccount(543, .02m, 250);
            BankAccount acct4 = new BankAccount(700, -6);
            BankAccount acct5 = new BankAccount(50, .07m);


            // Testing our functions 
            Console.WriteLine(acct2);
            acct1.CalculateInterest();
            Console.WriteLine(acct1);
            acct1.Deposit(3);
            Console.WriteLine(acct1);
            acct1.Withdrawl(-7);
            Console.WriteLine(acct1);
            acct2.CalculateInterest();
            Console.WriteLine(acct2);
            acct2.Deposit(500);
            Console.WriteLine(acct2);
            acct2.Withdrawl(1500);
            Console.WriteLine(acct2);
            acct2.Withdrawl(200);
            Console.WriteLine(acct2);
            acct2.CalculateInterest();
            Console.WriteLine(acct2);
            Console.WriteLine(acct3.Balance);
            Console.WriteLine(acct3.AnnualRate); 
            //acct3.AnnualRate = 0; <-- testing read only stuff

            // makes our list 
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(acct1);
            accounts.Add(acct2);
            accounts.Add(acct3);
            accounts.Add(acct4);
            accounts.Add(acct5);
            // Prints our list of customers 
            foreach (BankAccount acct in accounts)
            {   
                Console.WriteLine();
                Console.WriteLine(acct.ToString());
            }
        }
    }
}
