using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachineException : Exception
    {
        /// <summary>
        /// Displays thrown error message
        /// </summary>
        /// <param name="message"></param>
        public VendingMachineException(string message) : base(message)
        {

        }
    }
}
