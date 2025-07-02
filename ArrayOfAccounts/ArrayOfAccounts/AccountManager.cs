using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
    internal class AccountManager
    {
        Account[] account = new Account[10];
        static int count = 0;
        

        
        public void CreateAccount()
        {
            string accNumber, type, name;
            Random random = new Random();

            if (count < account.Length)
            {
                accNumber = "ICICI" + "1000" + random.Next(1000000, 9000000).ToString();

                Console.Write("Enter the type of Account you want to create \nEnter 's' for Savings or 'c' for current : ");
                type = Console.ReadLine();
                if (type == "s")
                {
                    type = "Savings";
                }
                else if (type == "c")
                {
                    type = "Current";
                }

                Console.Write("Enter the full name of the Account Holder: ");
                name = Console.ReadLine();
                double balance;
                do
                {
                    Console.Write("Your account must have a minimum balance of Rs. 500. \nPlease enter an amount to keep the minimum balance: ");
                    balance = double.Parse(Console.ReadLine());
                } while (balance < 500);

                account[count] = new Account(accNumber, name, balance, type);
                Console.Write(account[count].ToString());
                count++;

                
            }
            else
            {
                Console.WriteLine("Sorry no more accounts can be account");
            }
            
            
        }

        

        public void ViewBalance()
        {
            Console.WriteLine("Enter Account Number: ");
            string accnumber = Console.ReadLine();
            foreach (Account account in account)
            {
                if(account.AccountNumber == accnumber)
                {
                    Console.WriteLine("Current Balance: " + account.Balance);
                    break;
                }
            }


        }

        public void Deposit(double amount)
        {
            Console.Write("Enter Account Number: ");
            string accnumber = Console.ReadLine();

            foreach(Account account in account)
            {
                if(account.AccountNumber == accnumber)
                {
                    account.Balance += amount;
                    break;
                }
            }
            

            Console.WriteLine("Amount deposited successfully");
        }

        public void WithDraw(double amount)
        {
            Console.Write("Enter Account Number : ");
            string accnumber = Console.ReadLine();

            foreach(Account account in account)
            {
                if(account.AccountNumber == accnumber)
                {
                    account.Balance -= amount;
                    if(account.Balance < 500)
                    {
                        Console.WriteLine("Balance cannot be less than 500");
                        account.Balance += amount;
                        Console.WriteLine("Withdrawal unsuccessful");
                    }
                    else
                    {

                        Console.WriteLine("Amount withdrawn successfully");
                    }
                    break;
                }
            }
            
        }
    }
}
