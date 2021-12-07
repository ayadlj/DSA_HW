using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightTicketManagementSystem;

namespace FlightTicketManagementSystem
{
    public partial class FrmAddFight : Form
    {
        public FrmAddFight()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string airline = txtAirline.Text.Trim();
            string flightName = txtFilghtName.Text.Trim();
            string startPosition = txtStartPoint.Text.Trim();
            string destination = txtDestination.Text.Trim();
            string t1 = txtDepartureTime.Text.Trim();
            DateTime dt1;
            DateTime.TryParse(t1, out dt1);
            string t2 = txtArrivalTime.Text.Trim();
            DateTime dt2;
            DateTime.TryParse(t2, out dt2);
            float p = float.Parse(txtFightCost.Text.Trim());
            int cap = Convert.ToInt32(txtCapactiy.Text.Trim());
            MemoryData.SF.ScheduleFlightList.Add(new ScheduleFlight(airline, flightName, startPosition, destination, (DateTime.Now.Date + dt1.TimeOfDay), (DateTime.Now.Date + dt2.TimeOfDay), p, cap, p));

            this.DialogResult = DialogResult.OK;
        }

        private void FrmAddFight_Load(object sender, EventArgs e)
        {
            bool blnDebug = Toolkit.GetAppSetting<bool>("DebugState");
            if (blnDebug)
            {
                txtAirline.Text = "001";
                txtFilghtName.Text = "001";
                txtCapactiy.Text = "20";
                txtFightCost.Text = "1000";
                txtStartPoint.Text = "BJ";
                txtDestination.Text = "SH";
                txtArrivalTime.Text = "08:00:00";
                txtDepartureTime.Text = "10:00:00";
            }
        }
    }
}
