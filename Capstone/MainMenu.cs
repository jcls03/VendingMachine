using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class MainMenuCLI
    {
        private VendingMachine vm;
        public MainMenuCLI(VendingMachine vm)
        {
            this.vm = vm;
        }
        public void Display()
        {
            while (true)
            {
                PrintHeader();

                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1 --->> Display Vending Machine Items ");
                Console.WriteLine("2 --->> Purchase ");
                Console.WriteLine("Q --->> Quit ");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Displaying Vending Machine Items");
                    Submenu1 displayItems = new Submenu1(vm);
                    displayItems.Display();
                    
                    
                }
                else if (input == "2")
                {
                    Submenu2 submenu = new Submenu2();
                    submenu.Display();
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine("WELCOME!!!!");
        }
    }
}
