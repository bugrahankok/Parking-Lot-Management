namespace ParkingLotManagement
{
    partial class ParkingFloors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingFloors));
            this.floorTab1 = new System.Windows.Forms.TabPage();
            this.floorsTab = new System.Windows.Forms.TabControl();
            this.floorsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // floorTab1
            // 
            this.floorTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.floorTab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.floorTab1.Location = new System.Drawing.Point(4, 24);
            this.floorTab1.Name = "floorTab1";
            this.floorTab1.Padding = new System.Windows.Forms.Padding(3);
            this.floorTab1.Size = new System.Drawing.Size(987, 378);
            this.floorTab1.TabIndex = 0;
            this.floorTab1.Text = "Blue Floor";
            // 
            // floorsTab
            // 
            this.floorsTab.Controls.Add(this.floorTab1);
            this.floorsTab.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorsTab.Location = new System.Drawing.Point(-5, 0);
            this.floorsTab.Name = "floorsTab";
            this.floorsTab.SelectedIndex = 0;
            this.floorsTab.Size = new System.Drawing.Size(995, 406);
            this.floorsTab.TabIndex = 0;
            // 
            // ParkingFloors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(984, 399);
            this.Controls.Add(this.floorsTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParkingFloors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Parking Floors";
            this.floorsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage floorTab1;
        private System.Windows.Forms.TabControl floorsTab;
    }
}