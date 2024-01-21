namespace ParkingLotManagement
{
    partial class AdminMain
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
            this.showParkingLotsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.manageParkingLotsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showParkingLotsButton
            // 
            this.showParkingLotsButton.Location = new System.Drawing.Point(169, 106);
            this.showParkingLotsButton.Name = "showParkingLotsButton";
            this.showParkingLotsButton.Size = new System.Drawing.Size(112, 23);
            this.showParkingLotsButton.TabIndex = 0;
            this.showParkingLotsButton.Text = "Show Parking Lots";
            this.showParkingLotsButton.UseVisualStyleBackColor = true;
            this.showParkingLotsButton.Click += new System.EventHandler(this.ShowParkingLotsOnclick);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(206, 154);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogOutOnclick);
            // 
            // manageParkingLotsButton
            // 
            this.manageParkingLotsButton.Location = new System.Drawing.Point(162, 54);
            this.manageParkingLotsButton.Name = "manageParkingLotsButton";
            this.manageParkingLotsButton.Size = new System.Drawing.Size(119, 23);
            this.manageParkingLotsButton.TabIndex = 2;
            this.manageParkingLotsButton.Text = "Manage Parking Lots";
            this.manageParkingLotsButton.UseVisualStyleBackColor = true;
            this.manageParkingLotsButton.Click += new System.EventHandler(this.ManageParkingLotsOnclick);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(452, 272);
            this.Controls.Add(this.manageParkingLotsButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.showParkingLotsButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showParkingLotsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button manageParkingLotsButton;
    }
}