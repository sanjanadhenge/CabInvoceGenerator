namespace CabInvoiceGenerator
{
    public class CabInvoice
    {
        private static readonly double COST_PER_KM = 10.0;
        private static readonly double COST_PER_MIN = 1.0;
        private static readonly double MIN_FARE = 5.0;
        private double cabfare = 0.0;
        public double CalulateFare(double distance, double time)
        {
            this.cabfare = (distance * COST_PER_KM) + (time * COST_PER_MIN);
            return Math.Max(this.cabfare, MIN_FARE);

        }
    }
}