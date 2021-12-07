namespace FlightTicketManagementSystem
{
    partial class FrmDeleteFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteFlight));
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFilghtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(498, 133);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(150, 48);
            this.btnCancle.TabIndex = 21;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(60, 133);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 48);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFilghtName
            // 
            this.txtFilghtName.Location = new System.Drawing.Point(266, 21);
            this.txtFilghtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFilghtName.Name = "txtFilghtName";
            this.txtFilghtName.Size = new System.Drawing.Size(378, 31);
            this.txtFilghtName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Flight Number:";
            // 
            // FrmDeleteFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 206);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFilghtName);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeleteFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFilghtName;
        private System.Windows.Forms.Label label2;
    }
}