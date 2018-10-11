using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Submenu2
    {
        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("SubMenu 1");
                Console.WriteLine("1] >> Feed Money");
                Console.WriteLine("2] >> Select Product");
                Console.WriteLine("3] >> Finish Transaction");
                Console.WriteLine("Q] >> Return to Main Menu");
                //Console.WriteLine(&">> Current Money Provided : {FeedMoney}");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Performing submenu option 1");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Performing submenu option 2");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Performing submenu option 3");
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
