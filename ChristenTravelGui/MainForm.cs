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
namespace ChristenTravelGui
{
    public partial class MainForm : Form
    {
        Transport transport = new Transport();
        public MainForm()
        {

            InitializeComponent();
        
            
        }

        private void buttonShowConnections_Click(object sender, EventArgs e)
        {
            List<SearchedConnection> searchedConnectionList = new List<SearchedConnection>();
            List<Connection> connections =   transport.GetConnections(comboBoxFrom.Text, comboBoxTo.Text).ConnectionList;
            
            foreach (var connection in connections)
            {
               
                String stationFrom = connection.From.Station.Name;
                String stationTo = connection.To.Station.Name;
                String departure = formatDate(connection.From.Departure);
                String arrivel = formatDate(connection.To.Arrival);
                String travelTime = getTravelTime(connection);
                if (stationFrom != null && stationTo != null && departure != null && arrivel != null) { 
                SearchedConnection sc = new SearchedConnection(stationFrom, stationTo, departure, arrivel,travelTime);
                searchedConnectionList.Add(sc);
                }
            }
         
            dataGridAddElements(searchedConnectionList);
        }

        private string formatDate(string date)
        {
            return date;
        }

        private string getTravelTime(Connection connection)
        {
            int tag = Convert.ToInt32(connection.Duration.Substring(0, 2)) * 24;
            int houer = Convert.ToInt32(connection.Duration.Substring(3, 2));
            int minuts = Convert.ToInt32(connection.Duration.Substring(6, 2));
            return (tag + houer) + "h " + minuts + "min";
        }

        private void dataGridAddElements(List<SearchedConnection> searchedConnectionList)
        {
            dataGridVShowConnection.DataSource = searchedConnectionList;
            dataGridVShowConnection.Columns[0].HeaderText = "Von";
            dataGridVShowConnection.Columns[1].HeaderText = "Nach";
            dataGridVShowConnection.Columns[2].HeaderText = "Abfahrt";
            dataGridVShowConnection.Columns[3].HeaderText = "Ankunft";
            dataGridVShowConnection.Columns[4].HeaderText = "Dauer";
            dataGridVShowConnection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVShowConnection.RowHeadersVisible=false;
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
