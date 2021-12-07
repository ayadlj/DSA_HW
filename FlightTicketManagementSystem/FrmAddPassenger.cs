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
    public partial class FrmAddPassenger : Form
    {
        public FrmAddPassenger()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public int capacity;

        private void btnOk_Click(object sender, EventArgs e)
        {
            int seatNumber = 0;
            if (!int.TryParse(txtSeatNumber.Text.Trim(), out seatNumber))
            {
                MessageBox.Show("Enter the Valid seat number");
                return;
            }

            if (seatNumber > capacity)
            {
                MessageBox.Show("Enter the Valid seat number");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void FrmAddPassenger_Load(object sender, EventArgs e)
        {
            chkVip.Checked = false;
        }
    }
}
