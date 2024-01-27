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
            this.editAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showParkingLotsButton
            // 
            this.showParkingLotsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.showParkingLotsButton.FlatAppearance.BorderSize = 0;
            this.showParkingLotsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showParkingLotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showParkingLotsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.showParkingLotsButton.Location = new System.Drawing.Point(85, 100);
            this.showParkingLotsButton.Name = "showParkingLotsButton";
            this.showParkingLotsButton.Size = new System.Drawing.Size(276, 46);
            this.showParkingLotsButton.TabIndex = 0;
            this.showParkingLotsButton.Text = "Show Current Parkings";
            this.showParkingLotsButton.UseVisualStyleBackColor = false;
            this.showParkingLotsButton.Click += new System.EventHandler(this.ShowParkingLotsOnclick);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Location = new System.Drawing.Point(183, 227);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(86, 38);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogOutOnclick);
            // 
            // manageParkingLotsButton
            // 
            this.manageParkingLotsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.manageParkingLotsButton.FlatAppearance.BorderSize = 0;
            this.manageParkingLotsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageParkingLotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageParkingLotsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.manageParkingLotsButton.Location = new System.Drawing.Point(85, 48);
            this.manageParkingLotsButton.Name = "manageParkingLotsButton";
            this.manageParkingLotsButton.Size = new System.Drawing.Size(276, 46);
            this.manageParkingLotsButton.TabIndex = 2;
            this.manageParkingLotsButton.Text = "Manage Floors";
            this.manageParkingLotsButton.UseVisualStyleBackColor = false;
            this.manageParkingLotsButton.Click += new System.EventHandler(this.ManageParkingLotsOnclick);
            // 
            // editAdminButton
            // 
            this.editAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.editAdminButton.FlatAppearance.BorderSize = 0;
            this.editAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAdminButton.ForeColor = System.Drawing.SystemColors.Control;
            this.editAdminButton.Location = new System.Drawing.Point(85, 152);
            this.editAdminButton.Name = "editAdminButton";
            this.editAdminButton.Size = new System.Drawing.Size(276, 46);
            this.editAdminButton.TabIndex = 13;
            this.editAdminButton.Text = "Edit Admin";
            this.editAdminButton.UseVisualStyleBackColor = false;
            this.editAdminButton.Click += new System.EventHandler(this.editAdminButton_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(452, 308);
            this.Controls.Add(this.editAdminButton);
            this.Controls.Add(this.manageParkingLotsButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.showParkingLotsButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showParkingLotsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button manageParkingLotsButton;
        private System.Windows.Forms.Button editAdminButton;
    }
}