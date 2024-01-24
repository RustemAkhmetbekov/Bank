using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(int accountNumber, string accountOwner, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountOwner = accountOwner;
            Balance = balance;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountOwner}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }
}
