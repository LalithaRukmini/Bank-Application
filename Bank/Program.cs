using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankProgram 
    {
        static Bank bank= bank = new Bank("bofa");
        static void Main(string[] args)
        {
            while (true)
            {
                int selectedOption = ShowAndReadOptions();
                switch (selectedOption)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("your Account number is{0}", bank.AddCustomer(AddCustomer()).ToString());
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine(Withdraw());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine(Deposit());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine(Balance());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 5:
                        DisplayAllCustomers();

                        break;

                    case 6 :
                    default:
                        return;

                }

            }

        }

        static Customer AddCustomer()
        {
            Customer customer = (Customer)new Customer();
            Console.WriteLine("Enter your First Name:");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number:");
            long value = 0;
            long.TryParse(Console.ReadLine(), out value);
            customer.PhoneNumber = value;
            Console.WriteLine("Enter your Age:");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            customer.Age = age;
            return customer;
        }

        static string Withdraw()
        {
            Console.WriteLine("Enter the Account Number:");
            int accountNumber = int.Parse(Console.ReadLine());
            Customer customer = bank.Customers.Where(c => c.BankAccount.AccountNumber == accountNumber).SingleOrDefault();
            if (customer == null)
            {
                throw new ArgumentException("Not a valid Account Number");
            }
            Console.WriteLine("Enter the Amount to Withdraw:");
            Double amount = Double.Parse(Console.ReadLine());
            return customer.Withdraw(amount);
        }

        static string Deposit()
        {
            Console.WriteLine("Enter the Account Number:");
            int accountNumber = int.Parse(Console.ReadLine());
            Customer customer = bank.Customers.Where(c => c.BankAccount.AccountNumber == accountNumber).SingleOrDefault();
            if (customer == null)
            {
                throw new ArgumentException("Not a valid Account Number");
            }
            Console.WriteLine("Enter the Amount to Deposit:");
            Double amount = Double.Parse(Console.ReadLine());
            return customer.Deposit(amount);
        }

        static string Balance()
        {
            Console.WriteLine("Enter the Account Number:");
            int accountNumber = int.Parse(Console.ReadLine());
            Customer customer = bank.Customers.Where(c => c.BankAccount.AccountNumber == accountNumber).SingleOrDefault();
            if (customer == null)
            {
                throw new ArgumentException("Not a valid Account Number");
            }
            
            return customer.BalanceEnquiry();
        }

        static void DisplayAllCustomers()
        {
            foreach (Customer cust in bank.Customers)
            {
                Console.WriteLine("Customer Name is {0}  {1} ", cust.FirstName, cust.LastName);
                
            }

        }

        static int ShowAndReadOptions()
        {
            Console.WriteLine("Enter the number of the operation you want to perform :\n 1.AddCustomer \n 2. Withdraw amount \n 3. Deposit Amount \n 4.Check Balance \n 5.Display All Customers \n 6. Exit");
            return int.Parse(Console.ReadLine());

        }

    }

 }