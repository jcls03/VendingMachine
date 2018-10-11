using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public decimal balance { get; protected set; }

        public static Dictionary<string, List<VendingMachineItem>> stock { get; set; }
    }
}
