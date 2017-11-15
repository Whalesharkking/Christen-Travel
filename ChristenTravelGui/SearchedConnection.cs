using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristenTravelGui
{
    class SearchedConnection
    {
        public string stationFrom { get; set; }
        public string stationTo { get; set; }
        public string departure { get; set; }
        public string arrivel { get; set; }
        public string travelTime { get; set; }

        public SearchedConnection(string stationFrom, string stationTo, string departure, string arrivel, string travelTime)
        {
            this.stationFrom = stationFrom;
            this.stationTo = stationTo;
            this.departure = departure;
            this.arrivel = arrivel;
            this.travelTime = travelTime;
        }
    }
}
