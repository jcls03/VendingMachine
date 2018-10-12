using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        /// <summary>
        /// Instantiates a new vending machine item
        /// </summary>
        public VendingMachineItem vmi;

        /// <summary>
        /// Holds vending machine stock
        /// </summary>        
        public List<VendingMachineItem> Stock { get; }

        /// <summary>
        /// Holds the vending machine balance
        /// </summary>
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
            if (amountOfMoney > 0M)
            {
                Log newLog = new Log();
                string transaction = " FEED MONEY:  $";
                transaction += amountOfMoney;

                Balance += amountOfMoney;

                transaction = transaction + " $" + Balance;
                newLog.WriteToLog(transaction.PadRight(20));

                return Balance;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("HAHA What is this? We don't take negative money here pal!");
            }
            return Balance;
        }

        /// <summary>
        /// Says if item is in stock
        /// </summary>
        /// <param name="item"></param>
        /// <returns>bool</returns>
        public bool IsInStock(VendingMachineItem item)
        {
            if(item.Quantity > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                }
            }
            if(vmi == null)
            {
                throw new VendingMachineException("This position does not exist, try again, Dummy!");
            }
            if(vmi.Quantity == 0)
            {
                throw new VendingMachineException("Sorry, this delicious goodness is so popular it is OUT OF STOCK!");
            }
            if(Balance < vmi.Price)
            {
                throw new VendingMachineException("This item costs more than you can afford. Give us more money, ya cheapskate!");
               
            }

            Log newLog = new Log();
            string transaction = $" {vmi.Name} {vmi.SlotIdentifier} ${Balance}";

            vmi.Quantity -= 1;
            Balance -= vmi.Price;

            transaction = transaction + " $" + Balance;
            newLog.WriteToLog(transaction.PadLeft(20));

            return vmi;               
        }
        /// <summary>
        /// Clears the balance
        /// </summary>
        public void ClearBalance()
        {
            Balance = 0;
        }
    }
}
