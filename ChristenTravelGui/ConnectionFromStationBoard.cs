namespace ChristenTravelGui
{
     class ConnectionFromStationBoard 
    {
        /// <summary>
        /// get and set for stationFrom Name
        /// </summary>
        public string stationFrom { get; set; }

        /// <summary>
        /// get and set for stationTo Name
        /// </summary>
        public string stationTo { get; set; }

        /// <summary>
        /// get and set for departure time
        /// </summary>
        public string departure { get; set; }

        /// <summary>
        /// get and set for number of Bus or Train
        /// </summary>
        public string number { get; set; }


        public ConnectionFromStationBoard(string stationFrom, string stationTo, string departure, string number)
        {
            this.stationFrom = stationFrom;
            this.stationTo = stationTo;
            this.departure = departure;
            this.number = number;
        }
    }
}