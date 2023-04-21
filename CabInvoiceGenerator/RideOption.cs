using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideOption
    {
        public enum RideTypes
        {
            NORMAL,
            PREMIUM
        }
        public double costPerKms;
        public double costPerMinute;
        public double minimumfare;
        public RideOption(double costPerKms, double costPerMinute, double minimumfare)
        {
            this.costPerKms = costPerKms;
            this.costPerMinute = costPerMinute;
            this.minimumfare = minimumfare;
        }
        public RideOption()
        {

        }
        public RideOption SetRideValues(RideTypes ridetypes)
        {
            switch (ridetypes)
            {
                case RideTypes.NORMAL:
                    return new RideOption(10.0, 1.0, 5.0);
                case RideTypes.PREMIUM:
                    return new RideOption(15.0, 2.0, 20.0);
                default:
                    return null;
            }
        }
    }
}
