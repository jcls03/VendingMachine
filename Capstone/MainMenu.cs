using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class MainMenuCLI
    {
        private VendingMachine vm;

        /// <summary>
        /// Bringing in vending machine to Main Menu
        /// </summary>
        /// <param name="vm"></param>
        public MainMenuCLI(VendingMachine vm)
        {
            this.vm = vm;
        }

        /// <summary>
        /// Displaying Main Menu
        /// </summary>
        public void Display()
        {
            while (true)
            {
                PrintHeader();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___*Last Resort Vending Machine Main Menu*___");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" __ 1 __ <<--->> Display Vending Machine Items ");
                Console.WriteLine();
                Console.WriteLine(" __ 2 __ <<--->> Purchase ");
                Console.WriteLine();
                Console.WriteLine(" __ Q __ <<--->> Quit (if you dare!) ");
                Console.WriteLine();
                Console.Write("_____ What option do you want to select? _____ ");
                Console.WriteLine();
                Console.WriteLine();

                string input = Console.ReadLine().ToUpper();

                if (input == "1")
                {
                    Console.WriteLine();

                    Console.WriteLine("____Displaying Vending Machine Items____");
                    Submenu1 displayItems = new Submenu1(vm);
                    displayItems.Display();                    
                }
                else if (input == "2")
                {
                    Submenu2 submenu = new Submenu2(vm);
                    submenu.Display();
                }
                else if (input == "Q")
                {
                    Console.WriteLine("See ya later aligator!");
                    break;
                }
                else
                {
                    Console.WriteLine("HAHAHA invalid selection, Hit ENTER to try again!");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        /// <summary>
        /// Displays unwelcome message
        /// </summary>
        private void PrintHeader()
        {
            Console.WriteLine("---------WELCOME TO THE JERK COMPANY---------");
        }
    }
}
