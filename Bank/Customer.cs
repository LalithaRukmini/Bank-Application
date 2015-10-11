using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank
{

    class Customer
    {
        public Account BankAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }
        public int Age { get; set; }

        public string Withdraw(double amount)
        {
            
            if (amount < Balance)
            {
                return string.Format("Here is your Requested amount to Withdraw:{0} ", amount);
            }
            else
            {
               return "You have insufficient funds in your account";
            }

        }

        public string Deposit(double amount)
        {

            Balance = Balance + amount;

            return string.Format("Your new Account Balance is : {0}", Balance);

        }

        public string BalanceEnquiry()
        {
            return string.Format("Your Account Balance is : {0}", Balance);
        }

    }
}
