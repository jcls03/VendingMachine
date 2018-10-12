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
                Console.WriteLine("Make a delicious unhealthy purchase");
                Console.WriteLine();
                Console.WriteLine("1] >> Feed Me Money!!!");
                Console.WriteLine();
                Console.WriteLine("2] >> Select your junk food");
                Console.WriteLine();
                Console.WriteLine("3] >> Finish Transaction");
                Console.WriteLine();
                Console.WriteLine("Q] >> Return to Main Menu");
                Console.WriteLine();
                //Console.WriteLine(&">> Current Money Provided : {FeedMoney}");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine("How much money do you want to waste on junk?");
                    string moneyGiven = Console.ReadLine();
                    decimal amount = decimal.Parse(moneyGiven);
                    vm.FeedMoney(amount);

                    Console.WriteLine($"Your balance is {vm.Balance}.");
                    Console.WriteLine();
                    Console.WriteLine("Hit Enter to go back to select your junk food.");
                    Console.WriteLine();

                }
                else if (input == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your balance is {vm.Balance}.");
                    Console.WriteLine();
                    Console.WriteLine("Displaying Vending Machine Items");
                    Submenu1 displayItems = new Submenu1(vm);
                    displayItems.Display();
                    Console.WriteLine();
                    Console.WriteLine("Which junk food would you like to put in your pie hole?");                   
                    string selection = Console.ReadLine();
                    VendingMachineItem vmi = vm.SelectProduct(selection);

                    if(vmi == null)
                    {
                        Console.WriteLine("Sorry, this delicious goodness is out of stock.");
                    }                 
                    else
                    {
                        if (vm.Balance < vmi.Price)
                        {
                            Console.WriteLine("This item costs more than you can afford. Give us more money, ya cheapskate!");
                        }
                        else
                        {
                                                    
                                Console.WriteLine();
                                Console.WriteLine($"Here is your junk food ... {vmi.Name}.");
                                Console.WriteLine();
                                Console.WriteLine($"Your balance is {vm.Balance}");
                            
                        }
                    }                    
                    
                }
                else if (input == "3")
                {
                    Change change = new Change();
                    string customerChange = change.CalculatedChange(vm.Balance);

                    Console.WriteLine(customerChange);
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
