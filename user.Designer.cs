namespace FlightReservationSystem
{
    partial class user
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
            this.ShowTicket = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.UpdateTicket = new System.Windows.Forms.Button();
            this.Reservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowTicket
            // 
            this.ShowTicket.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ShowTicket.Location = new System.Drawing.Point(87, 75);
            this.ShowTicket.Name = "ShowTicket";
            this.ShowTicket.Size = new System.Drawing.Size(217, 41);
            this.ShowTicket.TabIndex = 0;
            this.ShowTicket.Text = "Show Tickets";
            this.ShowTicket.UseVisualStyleBackColor = true;
            this.ShowTicket.Click += new System.EventHandler(this.ShowTicket_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Logout.Location = new System.Drawing.Point(110, 369);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(161, 41);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button5_Click);
            // 
            // UpdateTicket
            // 
            this.UpdateTicket.Font = new System.Drawing.Font("Tahoma", 10F);
            this.UpdateTicket.Location = new System.Drawing.Point(87, 143);
            this.UpdateTicket.Name = "UpdateTicket";
            this.UpdateTicket.Size = new System.Drawing.Size(217, 41);
            this.UpdateTicket.TabIndex = 5;
            this.UpdateTicket.Text = "Update Ticket";
            this.UpdateTicket.UseVisualStyleBackColor = true;
            this.UpdateTicket.Click += new System.EventHandler(this.UpdateTicket_Click);
            // 
            // Reservation
            // 
            this.Reservation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Reservation.Location = new System.Drawing.Point(87, 204);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(217, 41);
            this.Reservation.TabIndex = 6;
            this.Reservation.Text = "Make New Reservation";
            this.Reservation.UseVisualStyleBackColor = true;
            this.Reservation.Click += new System.EventHandler(this.Reservation_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.Reservation);
            this.Controls.Add(this.UpdateTicket);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ShowTicket);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowTicket;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button UpdateTicket;
        private System.Windows.Forms.Button Reservation;
    }
}