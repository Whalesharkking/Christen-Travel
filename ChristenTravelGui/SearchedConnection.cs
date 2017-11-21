using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristenTravelGui
{
    class SearchedConnection
    {

        /// <summary>
        /// get and set for stationFrom
        /// </summary>
        public string stationFrom { get; set; }
        /// <summary>
        /// get and set for stationTo
        /// </summary>
        public string stationTo { get; set; }
        /// <summary>
        /// get and set for departure
        /// </summary>
        public string departure { get; set; }
        /// <summary>
        /// get and set for arrivel
        /// </summary>
        public string arrivel { get; set; }
        /// <summary>
        /// get and set for travelTime
        /// </summary>
        public string travelTime { get; set; }

        /// <summary>
        /// constructor for creating a new SearchedConnection Object
        /// </summary>
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
