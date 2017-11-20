using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace ChristenTravelGui
{
    public partial class MainForm : Form
    {
        Transport transport = new Transport();
        GMarkerGoogle marker;
        GMapOverlay gMapOverlay;
        DataTable dt;
        /// <summary>
        /// This is the MainForm Initalization
        /// </summary>
        public MainForm()
        {

            InitializeComponent();


        }
        /// <summary>
        /// Button Show Connections Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowConnections_Click(object sender, EventArgs e)
        {
            try
            {
                String stationFrom;
                String stationTo;
                String departure; 
                if (textBoxFrom.Text != "" && (textBoxTo.Text != "" && textBoxTo.Text != "Ort, Haltestelle"))
                {  
                    DateTime dt = dateTimePickerDepartTimeAndDate.Value.Date + dateTimePickerDepartTimeAndDate.Value.TimeOfDay;
                    List<SearchedConnection> searchedConnectionList = new List<SearchedConnection>();
                    List<Connection> connections = transport.GetConnections(textBoxFrom.Text, textBoxTo.Text,dt.ToString("dd.MM.yyyy H:mm")).ConnectionList;
                    foreach (var connection in connections)
                    { 
                        stationFrom = connection.From.Station.Name;
                       
                        stationTo = connection.To.Station.Name;
                        departure = formatDateToString(connection.From.Departure);
                        String arrivel = formatDateToString(connection.To.Arrival);
                        String travelTime = getTravelTime(connection);

                        if (stationFrom != null && stationTo != null && departure != null && arrivel != null)
                        {
                            
                            searchedConnectionList.Add(new SearchedConnection(stationFrom, stationTo, departure, arrivel, travelTime));
                            setGeoLocationFromStation(connection.From.Station);
                        }
                    }
                    dataGridAddElements(searchedConnectionList);
                  
                }
                else
                {      
                    string id = null;
                 
                    DateTime dt = dateTimePickerDepartTimeAndDate.Value.Date + dateTimePickerDepartTimeAndDate.Value.TimeOfDay;
                    List<Station> stc = transport.GetStations(textBoxFrom.Text).StationList;
                    List<ConnectionFromStationBoard> connectionsFromStationBoard = new List<ConnectionFromStationBoard>();
                    foreach(Station sten in stc)
                    {
                       
                        if (sten.Name == textBoxFrom.Text)
                        {
                            setGeoLocationFromStation(sten);
                            id = sten.Id;
                        }
                    }

                    List<StationBoard> sctt = transport.GetStationBoard(textBoxFrom.Text, id).Entries;
                 
                    foreach (StationBoard stt in sctt)
                    {
                        stationFrom = textBoxFrom.Text;
                        stationTo = stt.To;
                        departure = stt.Stop.Departure.ToString();
                        String busNumber = stt.Number;
                        connectionsFromStationBoard.Add(new ConnectionFromStationBoard(stationFrom, stationTo, departure, busNumber));
                    }
                    dataGridAddElements(connectionsFromStationBoard);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Console.WriteLine("{0} Exception caught.", exc);
            }


        }

        private void setGeoLocationFromStation(Station stc)
        {
         Coordinate c=   stc.Coordinate;
         double xcordinate=   c.XCoordinate;
         double ycordinate = c.YCoordinate;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(xcordinate, ycordinate);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
      


        }

      

        private DateTime formatStringToDate(string date)
        {
            // 2017 - 11 - 18T15: 44:00 + 0100 TO "dd.MM.yyyy H:mm"
           return DateTime.Parse(date.Replace('-', '/').Replace('T', ' ').Substring(0, date.LastIndexOf('+')));
        }


        /// <summary>
        /// In this Method a String is format to "dd.MM.yyyy H:mm"
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private string formatDateToString(string date)
        {
           
            // 2017 - 11 - 18T15: 44:00 + 0100 TO "dd.MM.yyyy H:mm"
            DateTime dt = DateTime.Parse(date.Replace('-', '/').Replace('T', ' ').Substring(0, date.LastIndexOf('+')));
        
            return dt.ToString("dd.MM.yyyy H:mm");
        }
        /// <summary>
        /// In this Method I calculate the Traveltime
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        private string getTravelTime(Connection connection)
        {
            int tag = Convert.ToInt32(connection.Duration.Substring(0, 2)) * 24;
            int houer = Convert.ToInt32(connection.Duration.Substring(3, 2));
            int minuts = Convert.ToInt32(connection.Duration.Substring(6, 2));
            return (tag + houer) + "h " + minuts + "min";
        }
        /// <summary>
        /// In this method I add the Connections to the dataGrid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="searchedConnectionList"></param>
        private void dataGridAddElements<T>(List<T> searchedConnectionList)
        {
                 
  
        var element = searchedConnectionList.FirstOrDefault();
            int i = 0;
            dataGridVShowConnection.DataSource = searchedConnectionList;
            dataGridVShowConnection.Columns[i].HeaderText = "Von";
            dataGridVShowConnection.Columns[++i].HeaderText = "Nach";
            dataGridVShowConnection.Columns[++i].HeaderText = "Abfahrt";
            if (element is SearchedConnection)
            {
                dataGridVShowConnection.Columns[++i].HeaderText = "Ankunft";
                dataGridVShowConnection.Columns[++i].HeaderText = "Dauer";
            }
            if (element is ConnectionFromStationBoard)
            {
                dataGridVShowConnection.Columns[++i].HeaderText = "Nummer";
            }
            dataGridVShowConnection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVShowConnection.RowHeadersVisible = false;

        }
      
       

        private void autoCompleteSearch(ComboBox comboBox, TextBox textBox)
        {
            comboBox.Items.Clear();
            try
            {
                if (textBox.Text.Count() >= 4)
                {

                    List<Station> stc = transport.GetStations(textBox.Text).StationList;

                    foreach (Station stt in stc)
                    {

                        comboBox.Items.Add(stt.Name);
                    }

                    comboBox.DroppedDown = true;

                }
            }
            catch (Exception exc)
            {
            }
        }

      

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            autoCompleteSearch(comboBoxFrom, textBoxFrom);

        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            autoCompleteSearch(comboBoxTo, textBoxTo);

        }

      

        private void textBoxFrom_KeyDown(object sender, KeyEventArgs e)
        {
            checkIfKeyDownIsDown( comboBoxFrom,e);
          
            
        }

        private void checkIfKeyDownIsDown( ComboBox comboBox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                comboBox.Focus();
                comboBox.SelectedIndex = 0;
                
            }
        }

        private void textBoxTo_KeyDown(object sender, KeyEventArgs e)
        {
            checkIfKeyDownIsDown(comboBoxTo, e);

        }

        private void comboBoxFrom_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownEvent(e, textBoxFrom, comboBoxFrom);
        
        }
        private void comboBoxTo_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownEvent(e, textBoxTo, comboBoxTo);
        }

        private void keyDownEvent(KeyEventArgs e, TextBox textBox, ComboBox comboBox)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox.Text = comboBox.SelectedItem.ToString();
                textBox.Focus();


            }
        }

 


        private void textBoxFrom_Click(object sender, EventArgs e)
        {
            textBoxFrom.Text = null;
            

        }

        private void textBoxTo_Click_1(object sender, EventArgs e)
        {
            textBoxTo.Text = null;
        }
    }
}
