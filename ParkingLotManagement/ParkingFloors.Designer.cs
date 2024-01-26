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
            this.floorTab1 = new System.Windows.Forms.TabPage();
            this.floorsTab = new System.Windows.Forms.TabControl();
            this.floorsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // floorTab1
            // 
            this.floorTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.floorTab1.Location = new System.Drawing.Point(4, 22);
            this.floorTab1.Name = "floorTab1";
            this.floorTab1.Padding = new System.Windows.Forms.Padding(3);
            this.floorTab1.Size = new System.Drawing.Size(798, 427);
            this.floorTab1.TabIndex = 0;
            this.floorTab1.Text = "tabPage1";
            // 
            // floorsTab
            // 
            this.floorsTab.Controls.Add(this.floorTab1);
            this.floorsTab.Location = new System.Drawing.Point(-2, -2);
            this.floorsTab.Name = "floorsTab";
            this.floorsTab.SelectedIndex = 0;
            this.floorsTab.Size = new System.Drawing.Size(806, 453);
            this.floorsTab.TabIndex = 0;
            // 
            // ParkingFloors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.floorsTab);
            this.Name = "ParkingFloors";
            this.Text = "ParkingFloors";
            this.floorsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage floorTab1;
        private System.Windows.Forms.TabControl floorsTab;
    }
}