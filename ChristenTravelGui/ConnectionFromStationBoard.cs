namespace ChristenTravelGui
{
     class ConnectionFromStationBoard 
    {
        public string stationFrom { get; set; }
        public string stationTo { get; set; }
        public string departure { get; set; }
        public string busNumber { get; set; }


        public ConnectionFromStationBoard(string stationFrom, string stationTo, string departure, string busNumber)
        {
            this.stationFrom = stationFrom;
            this.stationTo = stationTo;
            this.departure = departure;
            this.busNumber = busNumber;
        }
    }
}