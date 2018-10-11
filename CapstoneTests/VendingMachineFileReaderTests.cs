using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineFileReaderTests
    {
        [DataTestMethod]
        [DataRow("A1", "Potato Crisps", 3.05, "Chip")]
        public void ReturnItem(string )
        {
            //arrange
            VendingMachineFileReader vmfr = new VendingMachineFileReader();

            //act


            //assert
            Assert.AreEqual()
        }
    }
}
