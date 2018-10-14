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
        /// Holds the change to return to user
        /// </summary>
        /// <param name="balance"></param>
        /// <returns>string</returns>
        public string CalculatedChange (decimal balance)
        {
            Log newLog = new Log();
            string transaction = " GIVE CHANGE:  $";
            transaction += balance;

            decimal change = 0M;           
            change = balance;

            transaction = transaction + " $" + 0;
            newLog.WriteToLog(transaction.PadLeft(20));

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
            if (Quarters != 0 && Dimes != 0 && Nickels != 0)
            {
                return $"Your change is {Quarters} Quarter(s), {Dimes} Dime(s), and {Nickels} Nickel(s).";
            }
            else if (Quarters != 0 && Dimes != 0)
            {
                return $"Your change is {Quarters} Quarter(s) and {Dimes} Dime(s).";
            }
            else if (Quarters != 0 && Nickels != 0)
            {
                return $"Your change is {Quarters} Quarter(s) and {Nickels} Nickel(s).";
            }
            else if (Dimes != 0 && Nickels != 0)
            {
                return $"Your change is {Dimes} Dime(s) and {Nickels} Nickel(s).";
            }
            else if (Quarters != 0)
            {
                return $"Your change is {Quarters} Quarter(s).";
            }
            else if (Dimes != 0)
            {
                return $"Your change is {Dimes} Dime(s).";
            }
            else if (Nickels != 0)
            {
                return $"Your change is {Nickels} Nickel(s).";
            }
            else
            {
                return "No change for you!";
            }           
        }
    }
}
