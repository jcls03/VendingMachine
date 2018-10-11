using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            VendingMachineFileReader vmfr = new VendingMachineFileReader();
            List<VendingMachineItem> stock = vmfr.ReadFile();
            VendingMachine vm = new VendingMachine(stock);
            

            MainMenuCLI mainMenu = new MainMenuCLI(vm);
            mainMenu.Display();







        }
    }
}
