namespace FlightTicketManagementSystem
{
    partial class FrmQueryFight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryFight));
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtCapactiy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFightCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartureTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilghtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(320, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 33;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtCapactiy
            // 
            this.txtCapactiy.Location = new System.Drawing.Point(204, 209);
            this.txtCapactiy.Name = "txtCapactiy";
            this.txtCapactiy.ReadOnly = true;
            this.txtCapactiy.Size = new System.Drawing.Size(191, 21);
            this.txtCapactiy.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "Capacity for the Flight:";
            // 
            // txtFightCost
            // 
            this.txtFightCost.Location = new System.Drawing.Point(204, 182);
            this.txtFightCost.Name = "txtFightCost";
            this.txtFightCost.ReadOnly = true;
            this.txtFightCost.Size = new System.Drawing.Size(191, 21);
            this.txtFightCost.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "Flight Cost/Seat:";
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(204, 155);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.ReadOnly = true;
            this.txtArrivalTime.Size = new System.Drawing.Size(191, 21);
            this.txtArrivalTime.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "Arrival Time <HH:mm:ss>:";
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(204, 128);
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.ReadOnly = true;
            this.txtDepartureTime.Size = new System.Drawing.Size(191, 21);
            this.txtDepartureTime.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "Departure Time <HH:mm:ss>:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(204, 101);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(191, 21);
            this.txtDestination.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Destination:";
            // 
            // txtStartPosition
            // 
            this.txtStartPosition.Location = new System.Drawing.Point(204, 74);
            this.txtStartPosition.Name = "txtStartPosition";
            this.txtStartPosition.ReadOnly = true;
            this.txtStartPosition.Size = new System.Drawing.Size(191, 21);
            this.txtStartPosition.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "Start Position:";
            // 
            // txtFilghtName
            // 
            this.txtFilghtName.Location = new System.Drawing.Point(108, 12);
            this.txtFilghtName.Name = "txtFilghtName";
            this.txtFilghtName.Size = new System.Drawing.Size(191, 21);
            this.txtFilghtName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Flight Number:";
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(204, 47);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.ReadOnly = true;
            this.txtAirline.Size = new System.Drawing.Size(191, 21);
            this.txtAirline.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Airline:";
            // 
            // FrmQueryFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 241);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtCapactiy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFightCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDepartureTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStartPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilghtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAirline);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQueryFight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Query Fight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtCapactiy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFightCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartureTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilghtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.Label label1;
    }
}