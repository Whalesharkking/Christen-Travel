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
    /// <summary>
    /// This is the MainForm Class
    /// </summary>
    public partial class MainForm : Form
    {
        Transport transport = new Transport();
        /// <summary>
        /// This is the MainForm Initalization and set the GeoLocation to the default "Beckenried"
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            setGeoLocationDefaultOnStart();
        }

        /// <summary>
        /// This is the Mainpart of the Project first is the check if the user want to show the stationboard or connections( input From and To).
        /// Than I get the Values of the Station or Connection and Add them to the DataGrid. I have allso set the GeoLocation of the Departur Station.
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
                    foreach (var connection in connections) {
                        if (formatStringToDate(connection.From.Departure) > dt) { 
                        stationFrom = connection.From.Station.Name;
                        stationTo = connection.To.Station.Name;
                        departure = formatDateToString(connection.From.Departure);
                        String arrivel = formatDateToString(connection.To.Arrival);
                        String travelTime = getTravelTime(connection);
                        if (stationFrom != null && stationTo != null && departure != null && arrivel != null) {
                            searchedConnectionList.Add(new SearchedConnection(stationFrom, stationTo, departure, arrivel, travelTime));
                            setGeoLocationFromStation(connection.From.Station);
                        }
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
            
                Console.WriteLine("{0} Exception caught.", exc);
            }
        }

        /// <summary>
        /// Show the Station Location on a Map
        /// </summary>
        /// <param name="stc"></param>
        private void setGeoLocationFromStation(Station stc)
        {
         Coordinate c=   stc.Coordinate;
         double xCoordinate =   c.XCoordinate;
         double yCoordinate = c.YCoordinate;
            addPropertisAndCoorinatensTogMap(xCoordinate, yCoordinate);
        }

        /// <summary>
        /// Default GEOLocation set on Coordinates of Beckenried, when application start
        /// </summary>
        private void setGeoLocationDefaultOnStart() {
            double xCoordinate = 46.96685;
            double yCoordinate = 8.47525;
            addPropertisAndCoorinatensTogMap(xCoordinate, yCoordinate);
        }

        /// <summary>
        /// Set Propertis to GeoLocation and xCoordinate and yCoordinate
        /// </summary>
        /// <param name="xcordinate"></param>
        /// <param name="ycordinate"></param>
        private void addPropertisAndCoorinatensTogMap(double xCoordinate, double yCoordinate) {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(xCoordinate, yCoordinate);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
        }

        /// <summary>
        /// Format a String to a DateTime and return it
        /// </summary>
        /// <param name="date"></param>
        /// <returns>A DataTime formatted from a String</returns>
        private DateTime formatStringToDate(string date)
        {
            // 2017 - 11 - 18T15: 44:00 + 0100  Format TO "dd.MM.yyyy H:mm"
           return DateTime.Parse(date.Replace('-', '/').Replace('T', ' ').Substring(0, date.LastIndexOf('+')));
        }
       
        /// <summary>
        /// In this Method a String is format to "dd.MM.yyyy H:mm"
        /// </summary>
        /// <param name="date"></param>
        /// <returns>A formatted String</returns>
        private string formatDateToString(string date)
        {
            // 2017 - 11 - 18T15: 44:00 + 0100  Format TO "dd.MM.yyyy H:mm"
            DateTime dt = DateTime.Parse(date.Replace('-', '/').Replace('T', ' ').Substring(0, date.LastIndexOf('+')));
            return dt.ToString("dd.MM.yyyy H:mm");
        }

        /// <summary>
        /// In this Method I format the Duration and Calculate the traveltime
        /// </summary>
        /// <param name="Applicable connections"></param>
        /// <returns>The Duration in this Format to Houer and Minutes</returns>
        private string getTravelTime(Connection connection)
        {
            int tag = Convert.ToInt32(connection.Duration.Substring(0, 2)) * 24;
            int houer = Convert.ToInt32(connection.Duration.Substring(3, 2));
            int minuts = Convert.ToInt32(connection.Duration.Substring(6, 2));
            return (tag + houer) + "h " + minuts + "min";
        }

        /// <summary>
        /// In this method I add the Connections to the dataGrid, override the Header Text, set the AutoSize to Fill and remove the RowHeader.
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

        /// <summary>
        /// In this method I make to auto complete of the input Text. The auto complete text ist add to the ComboBox and the DropDown is open with the suggestion.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="textBox"></param>
        private void autoCompleteSearch(ComboBox comboBox, TextBox textBox)
        {
            try
            {
                comboBox.Items.Clear();
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
                Console.WriteLine("{0} Exception caught.", exc);
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

        /// <summary>
        /// Check if the Key "Down" is pressed and the set The Focus to the ComboBox and select the first index of the ComboBox
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Check if the Key "Delete" is pressed and then set the text of the selected Item from the Combobox to the TextBox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="textBox(ether TextBoxFrom or TextBoxTo)"></param>
        /// <param name="comboBox(ether ComBoxFrom  or ComboBoxTo)"></param>
        private void keyDownEvent(KeyEventArgs e, TextBox textBox, ComboBox comboBox)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox.Text = comboBox.SelectedItem.ToString();
                textBox.Focus();
            }
        }

        /// <summary>
        /// Set the TextBoxFrom Value to Null if I select it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFrom_Click(object sender, EventArgs e)
        {
            textBoxFrom.Text = null; 
        }

        /// <summary>
        /// Set the TextBoxTo Value to Null if I select it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e for the ClickEvent"></param>
        private void textBoxTo_Click_1(object sender, EventArgs e)
        {
            textBoxTo.Text = null;
        }


        /// <summary>
        /// Change Text in both direction From TextBoxTo to TextBoxFrom and the Text from TextBoxFrom in TextBoxTo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e for the ClickEvent"></param>
        private void pictureBoxChange_Click(object sender, EventArgs e) {
            string textBoxFromText = textBoxFrom.Text;
            string textBoxToText = textBoxTo.Text;
            textBoxFrom.Text = textBoxToText;
            textBoxTo.Text = textBoxFromText;
        }

        /// <summary>
        /// Click the Help Picture with the questionmark and open the HelpForm and disable the MainForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e for the ClickEvent"></param>
        private void pictureBoxHelp_Click(object sender, EventArgs e) {
            HelpForm helpForm = new HelpForm(this);
            this.Enabled = false;
            helpForm.Show();
        }
    }
    }

