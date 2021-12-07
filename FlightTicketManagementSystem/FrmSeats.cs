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
    public partial class FrmSeats : Form
    {
        public FrmSeats()
        {
            InitializeComponent();
        }

        public ScheduleFlight SF_CheckSeats { get; set; }

        private void FrmSeats_Load(object sender, EventArgs e)
        {
            dgvSeat.AllowUserToAddRows = false;
            dgvSeat.AllowUserToDeleteRows = false;
            dgvSeat.ReadOnly = true;

            InitDgvData();
        }

        private void InitDgvData()
        {
            DataTable dtRes = new DataTable();
            dtRes.Columns.Add("id");
            dtRes.Columns.Add("flightname");

            if (SF_CheckSeats != null)
            {
                foreach (int i in SF_CheckSeats.ListofFreePlaces())
                {
                    DataRow dRow = dtRes.NewRow();
                    dRow["id"] = i;
                    dRow["flightname"] = SF_CheckSeats.FlightName;

                    dtRes.Rows.Add(dRow);
                }
            }

            dgvSeat.DataSource = dtRes;
            dgvSeat.AllowUserToAddRows = false;
        }

        private void dgvSeat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int seatNumber = Convert.ToInt32(dgvSeat.Rows[rowIndex].Cells[0].Value);

            MemoryData.Bag = new BookFlight(SF_CheckSeats);
            MemoryData.Bag.BookFlightRecord(seatNumber);

            InitDgvData();
        }
    }
}
