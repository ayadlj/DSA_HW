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
    public partial class FrmManagement : Form
    {
        public FrmManagement()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tsslCurrentTime.Text = "    Current Time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FrmManagement_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void addFligthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddFight frmAddFight = new FrmAddFight();
            frmAddFight.StartPosition = FormStartPosition.CenterParent;
            frmAddFight.ShowDialog();
        }

        private void deleteFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteFlight frm = new FrmDeleteFlight();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void queryFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryFight frm = new FrmQueryFight();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void availableFilghtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryData.SF.ShowAvailableFlights();
            FrmAvaliableFlights frm = new FrmAvaliableFlights();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
