using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Submenu2
    {
        private VendingMachine vm;
        public Submenu2 (VendingMachine vm)
        {
            this.vm = vm;
        }
        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Make a delicious purchase");
                Console.WriteLine("1] >> Feed Money");
                Console.WriteLine("2] >> Select Product");
                Console.WriteLine("3] >> Finish Transaction");
                Console.WriteLine("Q] >> Return to Main Menu");
                //Console.WriteLine(&">> Current Money Provided : {FeedMoney}");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("How much money do you want to waste on junk?");
                    string moneyGiven = Console.ReadLine();
                    decimal amount = decimal.Parse(moneyGiven);
                    vm.FeedMoney(amount);

                    Console.WriteLine($"Your balance is {vm.Balance}.");

                    Console.WriteLine();

                    Console.WriteLine("Hit Enter to go back to select your junk food.");

                }
                else if (input == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your balance is {vm.Balance}.");
                    Console.WriteLine();
                    Console.WriteLine("Which junk food would you like to put in your pie hole?");                   
                    string selection = Console.ReadLine();
                    VendingMachineItem vmi = vm.SelectProduct(selection);

                    if(vmi == null || vmi.Quantity == 0)
                    {
                        Console.WriteLine("Sorry, this delicious goodness is out of stock.");
                    }
                    else
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine($"Your junk food selection is ... {vmi.Name} it costs ${vmi.Price}.");
                        Console.WriteLine($"Your balance is {vm.Balance}");
                    }                    
                    
                }
                else if (input == "3")
                {
                    
                    Console.WriteLine("Keep the change, ya filthy animal!");
                    Console.WriteLine();
                   // Console.WriteLine($"Your change is {GiveChange(Change)}.");
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
            }
        }
    }
}
