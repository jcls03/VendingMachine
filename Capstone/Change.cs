using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Change
    {
        /// <summary>
        /// Holds the amount of quarters
        /// </summary>
        public int Quarters { get; private set; }

        /// <summary>
        /// Holds the amount of nickels
        /// </summary>
        public int Nickels { get; private set; }

        /// <summary>
        /// Holds the amount of dimes
        /// </summary>
        public int Dimes { get; private set; }

        /// <summary>
        /// Total change returned to user
        /// </summary>
        public decimal TotalChange { get; private set; }

        public string CalculatedChange (decimal balance)
        {
            decimal change = 0M;

            change = balance;

           
            while (change -.25M >= 0.0M)
            {
                change -= .25M;
                Quarters++;
            }
            while (change -.10M >= 0.0M)
            {
                change -= .10M;
                Dimes++;
            }
            while (change -.05M >= 0.0M)
            {
                change -= .05M;
                Nickels++;
            }




            return $"Your change is {Quarters} Quarters and {Dimes} Dimes.";
        }
    }
}
