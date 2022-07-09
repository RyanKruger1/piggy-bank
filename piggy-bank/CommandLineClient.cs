using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank
{
    internal class CommandLineClient
    {

        private string _currentCoin;

        public CommandLineClient()
        {
            Console.Title = "Piggy Bank";
        }

        public void greet()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your piggy bank");
        }

        public void showAmount(decimal amount)
        {
            Console.WriteLine("You have $ {0} in your piggy bank ", amount);
        }

        public int showMenu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1) Add coin to your piggy bank.");
            Console.WriteLine("2) See piggy bank cash amount.");
            Console.WriteLine("3) Empty Piggy bank");
           
            try
            {
                int option = Int16.Parse(Console.ReadLine());
                Console.Clear();
                return option;
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid menu item number.");
                return -1;
            } 
        }

        public int AskCoin(IList<string> coins)
        { 
            Console.WriteLine("Please select which coin you would like to add:");
            int counter = 1;
            foreach(string c in coins)
            {
                Console.WriteLine("{0}) {1}", counter, c);
                counter++;
            }

            try
            {
                int option = Int16.Parse(Console.ReadLine());
                Console.Clear();
                if (option > 5 || option <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Please select a menu item by input their number");
                    return -1;
                }
                _currentCoin = coins[option - 1];
                return option;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid menu item number.");
                return -1;
            }
        }

        public void printAmount(decimal amount)
        {
            Console.WriteLine("You current have {0} in your piggy bank" , amount);
        }

        public int getAmountCoins()
        {
            Console.WriteLine("Please enter the amount of {0}s you would like to insert.",_currentCoin);
          
            try
            {
                int option = Int16.Parse(Console.ReadLine());
                Console.Clear();
                if (option <= 0)
                {
                    Console.WriteLine("Please select a menu item by input their number");
                    return -1;
                }

                return option;
            }
            catch (OverflowException ex)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid amount of coins");
                return -1;
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid amount.");
                return -1;
            }
        }

    }
}
