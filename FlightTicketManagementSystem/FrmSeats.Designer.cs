namespace FlightTicketManagementSystem
{
    partial class FrmSeats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeats));
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeat
            // 
            this.dgvSeat.AllowUserToAddRows = false;
            this.dgvSeat.AllowUserToDeleteRows = false;
            this.dgvSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeat.Location = new System.Drawing.Point(12, 36);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.ReadOnly = true;
            this.dgvSeat.RowTemplate.Height = 23;
            this.dgvSeat.Size = new System.Drawing.Size(285, 365);
            this.dgvSeat.TabIndex = 0;
            this.dgvSeat.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeat_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Optional seat number in selected Flight";
            // 
            // FrmSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSeat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Optional Seat";
            this.Load += new System.EventHandler(this.FrmSeats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeat;
        private System.Windows.Forms.Label label1;
    }
}