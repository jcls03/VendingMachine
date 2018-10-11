using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachineFileReader
    {
        static void Main()
        {
            

            

            using (StreamReader sr = new StreamReader(vendingmachine.csv))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    VendingMachineFileReader reader = new VendingMachineFileReader();
                    List<VendingMachineItems> stock = reader.ReadFile(line);

                    VendingMachine vm = new VendingMachine(stock);

                }
            }

                
                 
        }
    }
}
