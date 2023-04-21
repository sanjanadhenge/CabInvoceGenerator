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
        [Test]
        public void GivenUserId_WhenExecute_ShouldMatch()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            CabInvoice cabInvoice = new CabInvoice();
            InvoiceSummary invoiceSummary = cabInvoice.GetMultipleRideFare1(ride);
            InvoiceSummary expectedSummary = new InvoiceSummary(60.0, 2);
            Assert.AreEqual(expectedSummary, invoiceSummary);

        }
        [Test]
        public void GivenUserId_WhenExecute_ShouldReturn_Invoice()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            CabInvoice cabInvoice = new CabInvoice();
            cabInvoice.MapRidesTouser("Sanjana", ride);
            InvoiceSummary invoiceSummary = cabInvoice.GetInvoiceSummary("Sanjana");
            Assert.AreEqual(invoiceSummary.totalfare, 30.0);

        }
        [Test]
        public void Given_Parametrs_ShouldReturn_TotalFare()
        {
            CabInvoice cabInvoice = new CabInvoice();
            RideOption rideOption = new RideOption();
            RideOption result = rideOption.SetRideValues(RideOption.RideTypes.PREMIUM);
            double fare = cabInvoice.CalulateFare(result.costPerKms, result.costPerMinute, result.minimumfare, 3.0, 5.0);
            Assert.AreEqual(fare, 70.0);
        }

    }
}