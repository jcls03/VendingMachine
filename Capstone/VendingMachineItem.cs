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
        public bool IsStocked
        {
            get
            {
                return Quantity > 0;
            }
        }

        /// <summary>
        /// What slot the item is located in
        /// </summary>
        public string SlotIdentifier { get; set; }

        /// <summary>
        /// How many Items are left
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VendingMachineItem"/> class.        
        /// </summary>
        /// <param name="type">Sets the type</param>
        /// <param name="name">Sets the name</param>
        /// <param name="price">Sets the price</param>
        public VendingMachineItem(string type, string name, decimal price, string slotIdentifier)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
            this.SlotIdentifier = slotIdentifier;
            this.Quantity = 5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VendingMachineItem"/> class.        
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="slotIdentifier"></param>
        /// <param name="initialQuantity">The initial quantity to have in stock.</param>
        public VendingMachineItem(string type, string name, decimal price, string slotIdentifier, int initialQuantity)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
            this.SlotIdentifier = slotIdentifier;
            this.Quantity = initialQuantity;
        }

        /// <summary>
        /// After Item is dispensed, this noise is made
        /// </summary>
        /// <returns></returns>
        public string GetsConsumed(string Type)
        {
            if (Type == "Chip")
            {
                return "Crunch Crunch, Yum Yum!";
            }
            else if (Type == "Candy")
            {
                return "Munch Munch, Yum Yum!";
            }
            else if (Type == "Drink")
            {
                return "Glug Glug, Yum Yum!";
            }
            else if (Type == "Gum")
            {
                return "Chew Chew, Yum Yum!";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
