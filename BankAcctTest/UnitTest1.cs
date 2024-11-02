using System.Security.Principal;
// Had to add using to access methods etc
using ClassBankAcctBonus;

namespace BankAcctTest
{   
    // Testclass allows the testing function to see it as such
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // Testing if withdrawing a negative will return an erro 
        public void SubtractNeg()
        {
            // Arrange 
            BankAccount acct1 = new BankAccount(50, .10m);
            decimal amount = -10;
            decimal  expectedBalance = 50;
            decimal actualBalance;

            // Act 
            acct1.Withdrawl(amount);
            actualBalance = acct1.Balance; 
         
            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        // Test depositing a negative
        [TestMethod]
        public void AddNegative()
        {
            // Arrange 
            BankAccount acct1 = new BankAccount(50, .10m);
            decimal amount = -10;
            decimal expectedBalance = 50;
            decimal actualBalance;

            // Act 
            acct1.Deposit(amount);
            actualBalance = acct1.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        // Testing the overdraft feature 
        [TestMethod]
        public void Overdraft()
        {
            // Arrange 
            BankAccount acct2 = new CheckingAccount(100, .05m, 1000);
            decimal amount = 1200;
            decimal expectedBalance = 100;
            decimal actualBalance;

            // Act 
            acct2.Withdrawl(amount);
            actualBalance = acct2.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }



   


    }
}