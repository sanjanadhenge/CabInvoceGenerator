using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class RideRespository
    {
        private Dictionary<string, List<Ride>> userRideList = new Dictionary<string, List<Ride>>();
        public void AddCabRides(string userID, Ride[] ride)
        {
            bool checkList = this.userRideList.ContainsKey(userID);
            if (checkList == false)
            {
                this.userRideList.Add(userID, new List<Ride>());
            }
        }
        public Ride[] GetRides(string userID)
        {
            return this.userRideList[userID].ToArray();
        }
    }
}
