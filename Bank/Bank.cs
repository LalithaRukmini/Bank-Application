using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        List<Customer> customers = new List<Customer>();

        public Bank(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
        }


        public int AddCustomer(Customer iCustomer)
        {
            ValidateLastName(iCustomer);
            ValidateFirstName(iCustomer);
            ValidatePhoneNumber(iCustomer);
            ValidateAge(iCustomer);
            Account account = new Account();
            iCustomer.BankAccount = account;
            customers.Add(iCustomer);
            return iCustomer.BankAccount.AccountNumber;

        }

        private void ValidateLastName(Customer iCustomer)
        {
            if (!Regex.IsMatch(iCustomer.LastName, "[A-Z,a-z]"))
            {
                throw new ArgumentException("Please enter only characters");
            }
        }

        private void ValidateFirstName(Customer iCustomer)
        {
            if (!Regex.IsMatch(iCustomer.FirstName, "[A-Z,a-z]"))
            {
                throw new ArgumentException("Please enter only characters");
            }
        }

        private void ValidatePhoneNumber(Customer iCustomer)
        {
            if (iCustomer.PhoneNumber.ToString().Length != 10)
            {
                throw new ArgumentException("Please enter valid phone number");
            }
        }

        private void ValidateAge(Customer iCustomer)
        {
            if (iCustomer.Age <= 18)
            {
                throw new ArgumentException("Customer should be older than 18 years");
            }
        }


    }
}
