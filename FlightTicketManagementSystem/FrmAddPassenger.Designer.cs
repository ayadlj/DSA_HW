namespace FlightTicketManagementSystem
{
    partial class FrmAddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPassenger));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassengerEmail = new System.Windows.Forms.TextBox();
            this.txtLugguageType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkVip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Name";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(262, 25);
            this.txtPassengerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(374, 31);
            this.txtPassengerName.TabIndex = 1;
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(262, 81);
            this.txtSeatNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.ReadOnly = true;
            this.txtSeatNumber.Size = new System.Drawing.Size(374, 31);
            this.txtSeatNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seat Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passenger Email";
            // 
            // txtPassengerEmail
            // 
            this.txtPassengerEmail.Location = new System.Drawing.Point(262, 138);
            this.txtPassengerEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassengerEmail.Name = "txtPassengerEmail";
            this.txtPassengerEmail.Size = new System.Drawing.Size(374, 31);
            this.txtPassengerEmail.TabIndex = 5;
            // 
            // txtLugguageType
            // 
            this.txtLugguageType.Location = new System.Drawing.Point(262, 194);
            this.txtLugguageType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLugguageType.Name = "txtLugguageType";
            this.txtLugguageType.Size = new System.Drawing.Size(374, 31);
            this.txtLugguageType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lugguage Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Passenger Type";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(484, 304);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(150, 48);
            this.btnCancle.TabIndex = 19;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 304);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 48);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkVip
            // 
            this.chkVip.AutoSize = true;
            this.chkVip.Location = new System.Drawing.Point(262, 252);
            this.chkVip.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(77, 29);
            this.chkVip.TabIndex = 20;
            this.chkVip.Text = "VIP";
            this.chkVip.UseVisualStyleBackColor = true;
            // 
            // FrmAddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 375);
            this.Controls.Add(this.chkVip);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLugguageType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassengerEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Passenger";
            this.Load += new System.EventHandler(this.FrmAddPassenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.TextBox txtPassengerName;
        public System.Windows.Forms.TextBox txtSeatNumber;
        public System.Windows.Forms.TextBox txtPassengerEmail;
        public System.Windows.Forms.TextBox txtLugguageType;
        public System.Windows.Forms.CheckBox chkVip;
    }
}