using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Submenu2
    {
        private VendingMachine vm;
        public Submenu2(VendingMachine vm)
        {
            this.vm = vm;
        }

        /// <summary>
        /// Displays the purchase menu
        /// </summary>
        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Make a delicious unhealthy purchase");
                Console.WriteLine();
                Console.WriteLine("___ 1  <<--->> Feed Me Money! ___");
                Console.WriteLine();
                Console.WriteLine("___ 2 <<--->> Select your junk food ___");
                Console.WriteLine();
                Console.WriteLine("___ 3 <<--->> Finish Transaction ___");
                Console.WriteLine();
                Console.WriteLine("___ Q <<--->> Return to Main Menu ___");
                Console.WriteLine();
                Console.WriteLine($"     ***Your balance is ${vm.Balance} ***");
                Console.WriteLine();
                Console.Write("____What option do you want to select? ____ ");
                Console.WriteLine();
                Console.WriteLine();

                string input = Console.ReadLine().ToUpper();
                Console.WriteLine();
               
                if (input == "1")
                {                   
                        Console.WriteLine("How much money do you want to waste on junk (in whole dollars)?");
                        Console.WriteLine();
                        string moneyGiven = Console.ReadLine();
                        Console.WriteLine();

                    try
                    {
                        decimal amount = decimal.Parse(moneyGiven);
                        vm.FeedMoney(amount);
                        Console.WriteLine($"     ***Your balance is ${vm.Balance} ***");
                        Console.WriteLine();
                        Console.WriteLine("Hit Enter to go back to select your junk food.");
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("What in tarnation did you just do?  Let's try again.");
                        Console.WriteLine();
                        Console.WriteLine("Hit Enter to go back to select your junk food.");
                        Console.WriteLine();

                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine($"     ***Your balance is ${vm.Balance} ***");
                    Console.WriteLine();
                    Console.WriteLine("Displaying Vending Machine Items");
                    Console.WriteLine();
                    Console.WriteLine("****  Here are your wonderful snack options  ****");
                    Console.WriteLine();

                    List<VendingMachineItem> stock = vm.Stock;

                    foreach (VendingMachineItem item in stock)
                    {
                        Console.WriteLine($"{item.SlotIdentifier.PadLeft(10)} {item.Name.PadRight(20)} {item.Price}\t Qty. ({item.Quantity}) ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Which junk food would you like to put in your pie hole?");
                    Console.WriteLine();

                    string selection = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                   
                    try
                    {
                        VendingMachineItem vmi = vm.SelectProduct(selection);
                        string noises = vmi.GetsConsumed(vmi.Type);
                        Console.WriteLine();
                        Console.WriteLine($"Here is your junk food ... {vmi.Name}, {noises}.");
                        Console.WriteLine();
                        Console.WriteLine($"     ***Your balance is ${vm.Balance} ***");
                        Console.WriteLine();
                        Console.WriteLine("Hit ENTER to make another unhealthy eating decision or finish your transaction.");
                        Console.WriteLine();
                    }
                    catch (VendingMachineException ex)
                    {                    
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                        Console.WriteLine("Hit Enter to go back to select your junk food.");
                    }
                }
                else if (input == "3")
                {
                    Change change = new Change();
                    string customerChange = change.CalculatedChange(vm.Balance);
                    Console.WriteLine(customerChange);
                    vm.ClearBalance();
                    Console.WriteLine();
                    Console.WriteLine($"__* The Last Resort Vending Machine's balance is ${vm.Balance} *__");
                    Console.WriteLine();
                    Console.WriteLine("****Keep the change, ya filthy animal!****");
                    Console.WriteLine();
                    break;
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Hit ENTER to return to main menu.");
                    break;
                }
                else
                {
                    Console.WriteLine("HAHAHA What was that? Hit ENTER and try that again!");
                }
                Console.ReadLine();
            }
        }
    }
}
