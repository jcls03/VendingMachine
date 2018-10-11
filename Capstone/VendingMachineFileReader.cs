using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachineFileReader
    {
        public List<VendingMachineItem> ReadFile()
        {
            List<VendingMachineItem> stock = new List<VendingMachineItem>();
            using (StreamReader sr = new StreamReader("vendingmachine.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string [] parts = line.Split('|');
                    VendingMachineItem vmi = new VendingMachineItem(parts[3], parts[1], decimal.Parse(parts[2]), parts[0]);
                    stock.Add(vmi);
                }
            }
            return stock;    
                 
        }
    }
}
