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
            const int Pos_Type = 3;
            const int Pos_Slot = 0;
            const int Pos_Name = 1;
            const int Pos_Price = 2;

            List<VendingMachineItem> stock = new List<VendingMachineItem>();
            try
            {
                using (StreamReader sr = new StreamReader("vendingmachine.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split('|');
                        VendingMachineItem vmi = new VendingMachineItem(parts[Pos_Type], parts[Pos_Name], decimal.Parse(parts[Pos_Price]), parts[Pos_Slot]);
                        stock.Add(vmi);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading from file: " + ex.Message);
            }

            return stock;
        }
    }
}
