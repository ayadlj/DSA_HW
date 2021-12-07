namespace FlightTicketManagementSystem
{
    partial class FrmAvaliableFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvaliableFlights));
            this.dgvAvaliableFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliableFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvaliableFlights
            // 
            this.dgvAvaliableFlights.AllowUserToAddRows = false;
            this.dgvAvaliableFlights.AllowUserToDeleteRows = false;
            this.dgvAvaliableFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaliableFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvaliableFlights.Location = new System.Drawing.Point(0, 0);
            this.dgvAvaliableFlights.Name = "dgvAvaliableFlights";
            this.dgvAvaliableFlights.ReadOnly = true;
            this.dgvAvaliableFlights.Size = new System.Drawing.Size(748, 352);
            this.dgvAvaliableFlights.TabIndex = 0;
            this.dgvAvaliableFlights.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFlights_CellMouseDoubleClick);
            // 
            // FrmAvaliableFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 352);
            this.Controls.Add(this.dgvAvaliableFlights);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAvaliableFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Avaliable Flights";
            this.Load += new System.EventHandler(this.FrmAvaliableFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliableFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvaliableFlights;
    }
}