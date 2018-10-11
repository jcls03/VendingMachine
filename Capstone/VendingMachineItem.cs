using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachineItem
    {
        /// <summary>
        /// Type of Item
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Name of Item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of Item
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The Item is in stock
        /// </summary>
        public bool IsStocked { get; }

        /// <summary>
        /// What slot the item is located in
        /// </summary>
        public string SlotIdentifier { get; set; }

        /// <summary>
        /// How many Items are left
        /// </summary>
        public int Quantity { get; }

        /// <summary>
        /// Instantiates a new vending machine Item
        /// </summary>
        /// <param name="type">Sets the type</param>
        /// <param name="name">Sets the name</param>
        /// <param name="price">Sets the price</param>
        public VendingMachineItem(string type, string name, decimal price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// After Item is dispensed, this noise is made
        /// </summary>
        /// <returns></returns>
        public string GetsConsumed()
        {
            return null;
        }


    }
}
