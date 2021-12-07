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
    public partial class FrmDeleteFlight : Form
    {
        public FrmDeleteFlight()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DeleteFlight(txtFilghtName.Text.Trim());

            this.DialogResult = DialogResult.OK;
        }

        public void DeleteFlight(string flightName)
        {
            MemoryData.SF.ShowAvailableFlights();

            if (MemoryData.SF.ScheduleFlightList == null || MemoryData.SF.ScheduleFlightList.Count <= 0)
            {
                return;
            }
            int firstIndex = MemoryData.SF.ScheduleFlightList.Count - 1;
            for (int i = firstIndex; i >= 0; i--)
            {
                if (MemoryData.SF.ScheduleFlightList[i].FlightName == flightName)
                {
                    MemoryData.SF.ScheduleFlightList.RemoveAt(i);
                }
            }
        }
    }
}
