using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightTicketManagementSystem
{
    public partial class FrmQueryFight : Form
    {
        public FrmQueryFight()
        {
            InitializeComponent();
        }

        private void ClearTxt()
        {
            txtAirline.Text = txtStartPosition.Text = txtDestination.Text
                = txtDepartureTime.Text = txtArrivalTime.Text = txtCapactiy.Text 
                = txtFightCost.Text = string.Empty;
        }

        public ScheduleFlight searchFlight(string F_name)
        {
            foreach (ScheduleFlight flight in MemoryData.SF.ScheduleFlightList)
            {
                if (flight.FlightName == F_name)
                {
                    return flight;
                }
            }
            return null;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilghtName.Text.Trim()))
            {
                MessageBox.Show("Filght Name can not empty");
                return;
            }

            ClearTxt();

            ScheduleFlight sf = searchFlight(txtFilghtName.Text.Trim());
            if (sf == null)
            {
                MessageBox.Show("the filght not found");
                return;
            }

            txtAirline.Text = sf.AirLine;
            txtStartPosition.Text = sf.StartPosition;
            txtDestination.Text = sf.Destination;
            txtDepartureTime.Text = sf.DepartureTime.ToString("yyyy-MM-dd HH:mm:ss");
            txtArrivalTime.Text = sf.ArrivalTime.ToString("yyyy-MM-dd HH:mm:ss");
            txtCapactiy.Text = sf.capacity.ToString();
            txtFightCost.Text = sf.Price.ToString();
        }
    }
}
