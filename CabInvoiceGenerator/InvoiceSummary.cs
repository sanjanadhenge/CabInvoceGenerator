using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
   public class InvoiceSummary
    {
        public double totalfare;
        public double avergeFare;
        public int noOfRide;
        public InvoiceSummary(double totalfare, int noOfRide)
        {
            this.totalfare = totalfare;
            this.noOfRide = noOfRide;
            this.avergeFare = totalfare / noOfRide;
        }
    }
}
