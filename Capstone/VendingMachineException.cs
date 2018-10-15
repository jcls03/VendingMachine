using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachineException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendingMachineException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public VendingMachineException(string message) : base(message)
        {
        }
    }
}
