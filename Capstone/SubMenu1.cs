using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Submenu1
    {
        private VendingMachine vm;
        public Submenu1(VendingMachine vm)
        {
            this.vm = vm;
        }

        /// <summary>
        /// Displays item list
        /// </summary>
        public void Display()
        {            
            Console.WriteLine();
            Console.WriteLine("Here are your wonderful snack options!!!");

            List<VendingMachineItem> stock = vm.Stock;

            foreach(VendingMachineItem item in stock)
            {
                Console.WriteLine($"{item.SlotIdentifier.PadLeft(10)} {item.Name.PadRight(20)} {item.Price}\t Qty. ({item.Quantity}) ");
            }

            Console.WriteLine();
            Console.WriteLine("Hit Enter to go back to the Main Menu to purchase your delicious snack!");
            Console.WriteLine();
        }
    }
}
