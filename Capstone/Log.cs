using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
        public class Log
        {
            /// <summary>
            /// Writes to the log so no one steals our monies
            /// </summary>
            /// <param name="logOfVendingMachine"></param>
            public void WriteToLog(string logOfVendingMachine)
            {
                string directory = Environment.CurrentDirectory;
                string filename = "Log.txt";
                string fullPath = Path.Combine(directory, filename);

                try
                {
                    using (StreamWriter sw = new StreamWriter(filename, true))
                    {
                        sw.WriteLine(DateTime.Now + logOfVendingMachine);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error occured writing file" + e.Message);
                }
            }
        }     
}
