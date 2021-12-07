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
    public partial class FrmAvaliableFlights : Form
    {
        public FrmAvaliableFlights()
        {
            InitializeComponent();
        }

        private void FrmAvaliableFlights_Load(object sender, EventArgs e)
        {
            dgvAvaliableFlights.DataSource = GetAvailableFilgths();
            dgvAvaliableFlights.AllowUserToAddRows = false;
            dgvAvaliableFlights.AllowUserToDeleteRows = false;
            dgvAvaliableFlights.ReadOnly = true;
        }

        private DataTable GetAvailableFilgths()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("airline");
            dt.Columns.Add("flightname");
            dt.Columns.Add("startposition");
            dt.Columns.Add("destination");
            dt.Columns.Add("departuretime");
            dt.Columns.Add("arrivaltime");
            dt.Columns.Add("price");
            dt.Columns.Add("capacity");

            for (int i = 1; i <= MemoryData.SF.AvailScheduleFilghts.Count; i++)
            {
                ScheduleFlight sf = MemoryData.SF.AvailScheduleFilghts[i];
                DataRow newRow = dt.NewRow();
                newRow["id"] = i;
                newRow["airline"] = sf.AirLine;
                newRow["flightname"] = sf.FlightName;
                newRow["startposition"] = sf.StartPosition;
                newRow["destination"] = sf.Destination;
                newRow["departuretime"] = sf.DepartureTime.ToString("yyyy-MM-dd HH:mm:ss");
                newRow["arrivaltime"] = sf.ArrivalTime.ToString("yyyy-MM-dd HH:mm:ss");
                newRow["price"] = sf.Price;
                newRow["capacity"] = sf.capacity;

                dt.Rows.Add(newRow);
            }

            return dt;
        }

        private void dgvFlights_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = Convert.ToInt32(dgvAvaliableFlights.Rows[rowIndex].Cells[0].Value);
            FrmSeats frm = new FrmSeats();
            frm.SF_CheckSeats = MemoryData.SF.AvailScheduleFilghts[id];
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
