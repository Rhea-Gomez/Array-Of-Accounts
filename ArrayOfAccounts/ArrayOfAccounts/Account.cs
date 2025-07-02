using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; } = 500;
        public string AccountType { get; set; }

        public bool deposit = false;

        public bool withdraw = false;

        public Account(string accountNumber, string name, double balance, string accountType)
        {
            AccountNumber = accountNumber;
            Name= name;
            Balance = balance;
            AccountType = accountType;
        }

        public override string ToString()
        {
            return $"Account Holder Name: {Name}, \nAccount Number: {AccountNumber}, \nAccount Type : {AccountType}, \nAccount Balance: {Balance}\n";
        }

       

        

        

       
        }
    }
