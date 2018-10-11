using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public VendingMachineItem vmi;
        /// <summary>
        /// Holds vending machine stock
        /// </summary>
        
        public List<VendingMachineItem> Stock { get; }

        public decimal Balance { get; protected set; }

        /// <summary>
        /// Contstructor to instantiate a new vending machine
        /// </summary>
        /// <param name="">VendingMachineItems</param>
        public VendingMachine(List<VendingMachineItem> stock)
        {
            this.Stock = stock;
        }

        /// Amount of money entered by user
        public decimal FeedMoney(decimal amountOfMoney)
        {
            Balance += amountOfMoney;
            return Balance;
        }

        /// <summary>
        /// Selecting a product from a location in vending machine
        /// </summary>
        /// <param name="SlotIdentifier"></param>
        /// <returns>string</returns>
        public VendingMachineItem SelectProduct(string SlotIdentifier)
        {
            VendingMachineItem vmi = null;
            foreach(VendingMachineItem item in Stock)
            {
                if(item.SlotIdentifier == SlotIdentifier)
                {                 
                    vmi = item;
                    item.Quantity -= 1;
                    Balance -= item.Price;
                }
            }
          return vmi;
                
        }
        
        /// <summary>
        /// Dispense the item
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GiveItem (string name)
        {
            return null;
        }       

        /// <summary>
        /// Gives change to user (if needed)
        /// </summary>
        /// <param name="Change"></param>
        /// <returns>decimal</returns>
        public decimal GiveChange (decimal Change)
        {
            if(Balance < vmi.Price)
            {
                Console.WriteLine("This item costs more than you can afford. Give us more money, ya cheapskate!");
                return 0.00M;
            }
            return 0.00M;
        }       
        

        //NEED TO REVISIT AUDIT!!!!!!
        //public string Audit(string Date, string Time, FeedMoney, )
    }
}
