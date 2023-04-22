using CabInvoice;
using System.IO;

namespace CabInvoiceGeneratorUnitTes
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {

            //Arrange
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double distance = 2.0;
            int time = 5;
            double expected = 25;

            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(expected, fare);


        }
        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            //Arrange
            double actual, expected = 230;
            Ride[] cabRides = { new Ride(10, 15), new Ride(10, 15) };
            //Act
            actual = invoiceGenerator.CalculateFare(cabRides);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}