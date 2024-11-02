using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBankAcctBonus
{   // Adding our Bank Account Parent Class
    public class BankAccount
    {
        // setting our attributes for the class
        protected decimal balance;
        public decimal annualRate ;
        private decimal DEFAULT_RATE = 0.05m;

        // Making the functions read only from outside the class
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        // making this read only as well
        public decimal AnnualRate
        {
            get
            {
                return annualRate;
            }
          
        }

        // Making our constructor
        public BankAccount(decimal balance, decimal rate) 
        {   
            // Makes sure our balance is a positive
            if (balance < 0)
            {   // Tells us it must be positive
                Console.WriteLine("Positive Numbers Only");
            }
            else
            {   // If not, make the balance the input value
                this.balance = balance;
            }
            // Makes sure the rate is positive 
            if (rate < 0)
            {   
                // if its a negative, sets the rate to our defined default
                annualRate =DEFAULT_RATE;
            }
            else
            {   // Otherwise, sets the rate to what has been entered
                annualRate = rate;
            }
           

        }
        // creates our deposit method for the class (as a bool, since it will either work, or not. 
        public bool Deposit(decimal deposit)
        {   // checks the deposit is positive
            if (deposit < 0)
            {   // Sends our error if its negative and sends back false
                Console.WriteLine("Positive Numbers Only");
                return false;
            }
            // otherwise, updates the balance and returns true
            this.balance += deposit;
            return true;
        }
        // Creating our deposit method for the acct .Same as deposit and returns a true / false. 
        public virtual bool Withdrawl(decimal amount)
        {   // Checks if amount entered is a positive
            if (amount < 0) 
            {   
                // if not, prints an error and returns false
                Console.WriteLine("Positive Numbers Only");
                return false;
            }
            // checks if the account has the right amount to handle the deposit
            if (amount > balance) 
            {   // If not, prints an error and returns false 
                Console.WriteLine("Insufficient Funds");
                return false;
            }
            // Otherwise, completes the transaction and returns true
            this.balance -= amount;
            return true;
        }
        // creates a function to calculate and add our interest 
        public virtual void CalculateInterest()
        {   // writes that we are adding the interest
            Console.WriteLine($"Adding monthly interest of : {(balance * (annualRate / 12)).ToString("c")}");
            // adds the monthly balance to existing balance. We divide by the annual rate to get the monthly rate.
            balance += balance * (annualRate/12);
           
        }
        // Our to string ovveride to print the data for each customer 
        public override string ToString() 
        {
            var numberFormat = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            numberFormat.CurrencyNegativePattern = 1;
            return $"Acct Type : Basic , Balance : {balance.ToString("c",numberFormat)}, Annual Rate : {annualRate.ToString("p")}";
        }
    }
}
