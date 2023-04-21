using CabInvoiceGenerator;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Given_DistanceAndTime_ShouldReturn_TotalFare()
        {
            CabInvoice cabInvoice = new CabInvoice();
            double totalFare = cabInvoice.CalulateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }
        [Test]
        public void Test2()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            CabInvoice cabInvoice = new CabInvoice();
            double totalFare = cabInvoice.GetMultipleRideFare(ride);
            Assert.AreEqual(30.0, totalFare);

        }
    }
}