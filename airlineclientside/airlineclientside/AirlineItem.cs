using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airlineclientside
{
    class AirlineItem
    {
        public string flightID;
        public string departurePlace;
        public string arrivalPlace;
        public string departureTime;
        public string arrivalTime;
        public int price_first;
        public int price_eco;

        public AirlineItem(string id, string dplace, string aplace, string dtime, string atime, int pf, int pe) {
            this.flightID = id;
            this.departurePlace = dplace;
            this.arrivalPlace = aplace;
            this.departureTime = dtime;
            this.arrivalTime = atime;
            this.price_first = pf;
            this.price_eco = pe;

        }
    }
}
