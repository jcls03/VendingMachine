using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void UpdatingFeedMoneyBalance_ShouldReturnUpdatedBalance()
        {
            List<VendingMachineItem> items = new List<VendingMachineItem>()
            { new VendingMachineItem("chip", "dkd", 4.0M, "sfa") };
            // Arrange
            VendingMachine vm = new VendingMachine(items);
            // Act
            decimal balance = vm.FeedMoney(4.00M);


            // Assert
            Assert.AreEqual(4, balance);
        }

        [TestMethod]
        public void IsTheItemStocked_ReturnTrue()
        {
            List<VendingMachineItem> items = new List<VendingMachineItem>()
            { new VendingMachineItem("chip", "dkd", 4.0M, "A1") };
            // Arrange
            VendingMachine vm = new VendingMachine(items);

            // Act
            bool isStocked = vm.IsInStock(items[0]);

            // Assert
            Assert.IsTrue(isStocked);

        }

        [TestMethod]
        public void CanWeGetProductWithSlotIdentifier()
        {
            List<VendingMachineItem> items = new List<VendingMachineItem>()
            { new VendingMachineItem("chip", "dkd", 4.0M, "sfa") };
            // Arrange
            VendingMachine vm = new VendingMachine(items);
            // Act
            decimal balance = vm.FeedMoney(4.00M);

            VendingMachineItem vmi = vm.SelectProduct("sfa");
            // Assert
            Assert.IsNotNull(vmi);
            Assert.AreEqual(0, vm.Balance);
            Assert.AreEqual(4, vmi.Quantity);

        }
        [TestMethod]
        [ExpectedException(typeof(VendingMachineException))]
        public void WeDontGetAProductIfWeDontHaveEnoughMoney()
        {
            List<VendingMachineItem> items = new List<VendingMachineItem>()
            { new VendingMachineItem("chip", "dkd", 4.0M, "sfa") };
            // Arrange
            VendingMachine vm = new VendingMachine(items);
            // Act
            decimal balance = vm.FeedMoney(0.00M);

            VendingMachineItem vmi = vm.SelectProduct("sfa");
            // Assert
            

        }

    }
}
