using System.Xml.Serialization;

namespace ArrayOfAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] account = new Account[10];
            AccountManager acc = new AccountManager();
            int choice;

            do
            {
                Console.WriteLine("Welcome to ICICI Bank");
                Console.WriteLine("1. Create an Account\n2. View Balance\n3. Deposit\n4. Withdraw\n5. Exit");
                Console.Write("Enter you choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        acc.CreateAccount();
                        Console.WriteLine();
                        
                        break;
                    case 2:
                        acc.ViewBalance();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter Amount to be deposited: ");
                        double amount = double.Parse(Console.ReadLine());
                        acc.Deposit(amount);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter amount to be withdrawn: ");
                        amount = double.Parse(Console.ReadLine());
                        acc.WithDraw(amount);
                        Console.WriteLine();
                        break;
                    case 5: //to do exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            } while (choice != 5);

        }
    }
}
