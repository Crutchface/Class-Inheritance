using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// new class to namespace 
namespace ClassBankAcctBonus
{   
    // Defining the subclass and its parent class 
    public class CheckingAccount : BankAccount // <-- Parent Class
    {   
        // Adding our additional attributes for the subclass
        private decimal overdraft;

        // adding our constructor and passes values to base values 
        public CheckingAccount(decimal balance, decimal annualrate, decimal overdraft):base(balance, annualrate)
        {   // Checks if our overdraft acct is set up as a positive number 
            if (overdraft < 0)
            {
                // Tells us it must be positive
                Console.WriteLine("Positive Numbers Only");

            }
            // adds the overdraft otherwise 
            else 
            { 
                this.overdraft = overdraft;
            }

            
        }
        // Overriding our withdrawl function to allow for the overdraft 
        public override bool Withdrawl(decimal amount)
        {   
            //still have to make sure its a positive value 
            if (amount < 0)
            {
                amount = 0;
                Console.WriteLine("Insufficient Funds");
                return false;
            }
            // checks if the balance and the withdrawl are greater than the negative value of the overdraft we have set 
            if (balance - amount < -overdraft)
            {   

                // Tells us inufficient funds and overdraft 
                Console.WriteLine("Insufficient Funds / Overdraft");
                return false; 
            }
            // otherwise allows the transaction
            balance -= amount;
            return true;
        }
        // overrides our interest so we cant add interest on a negative value 
        public override void CalculateInterest()
        {   // checks to ensure that the balance is over zero
            if (balance < 0)
            {
                Console.WriteLine("Sorry. No Interest For Neagtive values ");
            }   
            // Otherwise completes the transaction
            else
            {
                Console.WriteLine($"Adding monthly interest of : {(balance * (annualRate / 12)).ToString("c")}");
                balance += balance * (annualRate / 12);
            }

        }
        // overrides our tostring 
        public override string ToString()
        {   
            // adds our overdraft to the base tostring 
            return base.ToString() + $" Overdraft : {overdraft}";
        }
    }
}
