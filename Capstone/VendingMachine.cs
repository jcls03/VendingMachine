using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        /// <summary>
        /// Holds vending machine stock
        /// </summary>        
        public List<VendingMachineItem> Stock { get; }

        /// <summary>
        /// Holds the vending machine balance
        /// </summary>
        public decimal Balance { get; private set; }

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
            }

            return Balance;
        }

        /// <summary>
        /// Selecting a product from a location in vending machine
        /// </summary>
        /// <param name="slotIdentifier"></param>
        /// <returns>string</returns>
        public VendingMachineItem SelectProduct(string slotIdentifier)
        {
            VendingMachineItem vmi = null;
            foreach (VendingMachineItem item in Stock)
            {
                if (item.SlotIdentifier == slotIdentifier)
                {
                    vmi = item;
                }
            }

            if (vmi == null)
            {
                throw new VendingMachineException("This position does not exist, try again, Dummy!");
            }

            if (vmi.Quantity == 0)
            {
                throw new VendingMachineException("Sorry, this delicious goodness is so popular it is OUT OF STOCK!");
            }

            if (Balance < vmi.Price)
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
