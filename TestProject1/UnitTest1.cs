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
    }
}