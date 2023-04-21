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
        public void Get_Multiple_Ride()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            CabInvoice cabInvoice = new CabInvoice();
            double totalFare = cabInvoice.GetMultipleRideFare(ride);
            Assert.AreEqual(30.0, totalFare);

        }
        [Test]
        public void Given_DistanceAndTime_ShouldReturn_TotalFare_NoOfRides_Avg()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            CabInvoice cabInvoice = new CabInvoice();
            InvoiceSummary inverseSummary = cabInvoice.GetMultipleRideFare1(ride);
            Assert.AreEqual(30.0, inverseSummary.totalfare);

        }
    }
}