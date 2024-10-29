using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class BankAccount
    {
        public string AccountNumber { get; set;}
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount (string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Whitdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Console.WriteLine($"Whitdrawing {amount:c} from account number {AccountNumber}"); 
                Balance -= amount;
            }
            else 
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Adding {amount:c} to account number {AccountNumber}");
            Balance += amount;
        }

        public string DisplayInfo()
        {
            return
            $"\nAccount Number: {AccountNumber}\n" +
            $"Account Holder: {AccountHolder}\n" +
            $"Balance: {Balance:c}\n";
        }

    }
}
