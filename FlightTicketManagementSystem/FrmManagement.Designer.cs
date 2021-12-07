namespace FlightTicketManagementSystem
{
    partial class FrmManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagement));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addFligthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableFilghtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFligthToolStripMenuItem,
            this.deleteFlightToolStripMenuItem,
            this.queryFlightToolStripMenuItem,
            this.availableFilghtsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFligthToolStripMenuItem
            // 
            this.addFligthToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFligthToolStripMenuItem.Image")));
            this.addFligthToolStripMenuItem.Name = "addFligthToolStripMenuItem";
            this.addFligthToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.addFligthToolStripMenuItem.Text = "Add Flight";
            this.addFligthToolStripMenuItem.Click += new System.EventHandler(this.addFligthToolStripMenuItem_Click);
            // 
            // deleteFlightToolStripMenuItem
            // 
            this.deleteFlightToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteFlightToolStripMenuItem.Image")));
            this.deleteFlightToolStripMenuItem.Name = "deleteFlightToolStripMenuItem";
            this.deleteFlightToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.deleteFlightToolStripMenuItem.Text = "Delete Flight";
            this.deleteFlightToolStripMenuItem.Click += new System.EventHandler(this.deleteFlightToolStripMenuItem_Click);
            // 
            // queryFlightToolStripMenuItem
            // 
            this.queryFlightToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("queryFlightToolStripMenuItem.Image")));
            this.queryFlightToolStripMenuItem.Name = "queryFlightToolStripMenuItem";
            this.queryFlightToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.queryFlightToolStripMenuItem.Text = "Query Flight";
            this.queryFlightToolStripMenuItem.Click += new System.EventHandler(this.queryFlightToolStripMenuItem_Click);
            // 
            // availableFilghtsToolStripMenuItem
            // 
            this.availableFilghtsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("availableFilghtsToolStripMenuItem.Image")));
            this.availableFilghtsToolStripMenuItem.Name = "availableFilghtsToolStripMenuItem";
            this.availableFilghtsToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.availableFilghtsToolStripMenuItem.Text = "Available Filghts";
            this.availableFilghtsToolStripMenuItem.Click += new System.EventHandler(this.availableFilghtsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslCurrentTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(316, 17);
            this.toolStripStatusLabel1.Text = "Welcome to use the flight ticket management system";
            // 
            // tsslCurrentTime
            // 
            this.tsslCurrentTime.Name = "tsslCurrentTime";
            this.tsslCurrentTime.Size = new System.Drawing.Size(106, 17);
            this.tsslCurrentTime.Text = "    Current Time: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Ticket Management System";
            this.Load += new System.EventHandler(this.FrmManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFligthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableFilghtsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrentTime;
        private System.Windows.Forms.Timer timer1;
    }
}