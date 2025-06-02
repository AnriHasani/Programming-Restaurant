namespace Restaurant
{
    partial class SeatSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatSelection));
            btn_Details = new Button();
            panelSeats = new Panel();
            pictureBox14 = new PictureBox();
            table_10 = new PictureBox();
            table_9 = new PictureBox();
            table_5 = new PictureBox();
            table_8 = new PictureBox();
            table_4 = new PictureBox();
            table_7 = new PictureBox();
            table_6 = new PictureBox();
            table_3 = new PictureBox();
            table_2 = new PictureBox();
            table_1 = new PictureBox();
            btn_Create_Reservation = new Button();
            btn_LogOut = new Button();
            btn_Cancel_Reservation = new Button(); // New button for canceling reservations
            panelSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_1).BeginInit();
            SuspendLayout();
            // 
            // btn_Details
            // 
            btn_Details.Location = new Point(360, 389);
            btn_Details.Name = "btn_Details";
            btn_Details.Size = new Size(94, 29);
            btn_Details.TabIndex = 1;
            btn_Details.Text = "Details";
            btn_Details.UseVisualStyleBackColor = true;
            btn_Details.Click += btn_Details_Click;
            // 
            // panelSeats
            // 
            panelSeats.AutoScroll = true;
            panelSeats.BackColor = Color.PeachPuff;
            panelSeats.Controls.Add(pictureBox14);
            panelSeats.Controls.Add(table_10);
            panelSeats.Controls.Add(table_9);
            panelSeats.Controls.Add(table_5);
            panelSeats.Controls.Add(table_8);
            panelSeats.Controls.Add(table_4);
            panelSeats.Controls.Add(table_7);
            panelSeats.Controls.Add(table_6);
            panelSeats.Controls.Add(table_3);
            panelSeats.Controls.Add(table_2);
            panelSeats.Controls.Add(table_1);
            panelSeats.Location = new Point(38, 66);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(693, 298);
            panelSeats.TabIndex = 19;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = (Image)resources.GetObject("pictureBox14.BackgroundImage");
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox14.Location = new Point(341, 45);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(129, 139);
            pictureBox14.TabIndex = 17;
            pictureBox14.TabStop = false;
            // 
            // table_10
            // 
            table_10.BackgroundImage = (Image)resources.GetObject("table_10.BackgroundImage");
            table_10.BackgroundImageLayout = ImageLayout.Stretch;
            table_10.Location = new Point(503, 73);
            table_10.Name = "table_10";
            table_10.Size = new Size(60, 60);
            table_10.TabIndex = 15;
            table_10.TabStop = false;
            table_10.Click += table_Click; // Use a common click event handler
            // 
            // table_9
            // 
            table_9.BackgroundImage = (Image)resources.GetObject("table_9.BackgroundImage");
            table_9.BackgroundImageLayout = ImageLayout.Stretch;
            table_9.Location = new Point(606, 176);
            table_9.Name = "table_9";
            table_9.Size = new Size(60, 60);
            table_9.TabIndex = 11;
            table_9.TabStop = false;
            table_9.Click += table_Click; // Use a common click event handler
            // 
            // table_5
            // 
            table_5.BackgroundImage = (Image)resources.GetObject("table_5.BackgroundImage");
            table_5.BackgroundImageLayout = ImageLayout.Stretch;
            table_5.Location = new Point(150, 176);
            table_5.Name = "table_5";
            table_5.Size = new Size(60, 60);
            table_5.TabIndex = 8;
            table_5.TabStop = false;
            table_5.Click += table_Click; // Use a common click event handler
            // 
            // table_8
            // 
            table_8.BackgroundImage = (Image)resources.GetObject("table_8.BackgroundImage");
            table_8.BackgroundImageLayout = ImageLayout.Stretch;
            table_8.Location = new Point(503, 176);
            table_8.Name = "table_8";
            table_8.Size = new Size(60, 60);
            table_8.TabIndex = 7;
            table_8.TabStop = false;
            table_8.Click += table_Click; // Use a common click event handler
            // 
            // table_4
            // 
            table_4.BackgroundImage = (Image)resources.GetObject("table_4.BackgroundImage");
            table_4.BackgroundImageLayout = ImageLayout.Stretch;
            table_4.Location = new Point(45, 176);
            table_4.Name = "table_4";
            table_4.Size = new Size(60, 60);
            table_4.TabIndex = 6;
            table_4.TabStop = false;
            table_4.Click += table_Click; // Use a common click event handler
            // 
            // table_7
            // 
            table_7.BackgroundImage = (Image)resources.GetObject("table_7.BackgroundImage");
            table_7.BackgroundImageLayout = ImageLayout.Stretch;
            table_7.Location = new Point(606, 73);
            table_7.Name = "table_7";
            table_7.Size = new Size(60, 60);
            table_7.TabIndex = 5;
            table_7.TabStop = false;
            table_7.Click += table_Click; // Use a common click event handler
            // 
            // table_6
            // 
            table_6.BackgroundImage = (Image)resources.GetObject("table_6.BackgroundImage");
            table_6.BackgroundImageLayout = ImageLayout.Stretch;
            table_6.Location = new Point(253, 176);
            table_6.Name = "table_6";
            table_6.Size = new Size(60, 60);
            table_6.TabIndex = 4;
            table_6.TabStop = false;
            table_6.Click += table_Click; // Use a common click event handler
            // 
            // table_3
            // 
            table_3.BackgroundImage = (Image)resources.GetObject("table_3.BackgroundImage");
            table_3.BackgroundImageLayout = ImageLayout.Stretch;
            table_3.Location = new Point(253, 73);
            table_3.Name = "table_3";
            table_3.Size = new Size(60, 60);
            table_3.TabIndex = 2;
            table_3.TabStop = false;
            table_3.Click += table_Click; // Use a common click event handler
            // 
            // table_2
            // 
            table_2.BackgroundImage = (Image)resources.GetObject("table_2.BackgroundImage");
            table_2.BackgroundImageLayout = ImageLayout.Stretch;
            table_2.Location = new Point(150, 73);
            table_2.Name = "table_2";
            table_2.Size = new Size(60, 60);
            table_2.TabIndex = 1;
            table_2.TabStop = false;
            table_2.Click += table_Click; // Use a common click event handler
            // 
            // table_1
            // 
            table_1.BackgroundImage = (Image)resources.GetObject("table_1.BackgroundImage");
            table_1.BackgroundImageLayout = ImageLayout.Stretch;
            table_1.Location = new Point(45, 73);
            table_1.Name = "table_1";
            table_1.Size = new Size(60, 60);
            table_1.TabIndex = 0;
            table_1.TabStop = false;
            table_1.Click += table_Click; // Use a common click event handler
            // 
            // btn_Create_Reservation
            // 
            btn_Create_Reservation.BackColor = Color.DarkRed;
            btn_Create_Reservation.Font = new Font("Segoe UI", 14F);
            btn_Create_Reservation.Location = new Point(296, 12);
            btn_Create_Reservation.Name = "btn_Create_Reservation";
            btn_Create_Reservation.Size = new Size(245, 48);
            btn_Create_Reservation.TabIndex = 18;
            btn_Create_Reservation.Text = "Create a reservation";
            btn_Create_Reservation.UseVisualStyleBackColor = false;
            btn_Create_Reservation.Click += btn_Create_Reservation_Click;
            // 
            // btn_LogOut
            // 
            btn_LogOut.BackColor = Color.IndianRed;
            btn_LogOut.Location = new Point(12, 12);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(94, 29);
            btn_LogOut.TabIndex = 18;
            btn_LogOut.Text = "Log Out";
            btn_LogOut.UseVisualStyleBackColor = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // btn_Cancel_Reservation
            // 
            btn_Cancel_Reservation.BackColor = Color.OrangeRed;
            btn_Cancel_Reservation.Font = new Font("Segoe UI", 14F);
            btn_Cancel_Reservation.Location = new Point(296, 60);
            btn_Cancel_Reservation.Name = "btn_Cancel_Reservation";
            btn_Cancel_Reservation.Size = new Size(245, 48);
            btn_Cancel_Reservation.TabIndex = 19;
            btn_Cancel_Reservation.Text = "Cancel Reservation";
            btn_Cancel_Reservation.UseVisualStyleBackColor = false;
            btn_Cancel_Reservation.Click += btn_Cancel_Reservation_Click; // Link to cancel reservation method
            // 
            // SeatSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cancel_Reservation); // Add the cancel button to the form
            Controls.Add(btn_LogOut);
            Controls.Add(btn_Create_Reservation);
            Controls.Add(panelSeats);
            Controls.Add(btn_Details);
            Name = "SeatSelection";
            Text = "Seat Selection";
            Load += SeatSelection_Load;
            panelSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_10).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_9).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_8).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_7).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Details;
        private Panel panelSeats;
        private PictureBox pictureBox14;
        private PictureBox table_10;
        private PictureBox table_9;
        private PictureBox table_5;
        private PictureBox table_8;
        private PictureBox table_4;
        private PictureBox table_7;
        private PictureBox table_6;
        private PictureBox table_3;
        private PictureBox table_2;
        private PictureBox table_1;
        private Button btn_Create_Reservation;
        private Button btn_LogOut;
        private Button btn_Cancel_Reservation;
    }
}
