using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion )
        {

            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
            return getConnection(request);
            
        }

        public object GetConnectionsWithTimeFilter(string text1, string text2, string v)
        {
            throw new NotImplementedException();
        }

        public Connections GetConnections(string fromStation, string toStattion, string dateTime)
        {

          var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&datetime="+dateTime +"&limt="+5);
          return  getConnection(request);
        
        }

        private Connections getConnection(WebRequest request)
        {
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                  JsonConvert.DeserializeObject<Connections>(readToEnd,
                  new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return connections;
            }

            return null;

        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }

   
    }
}
