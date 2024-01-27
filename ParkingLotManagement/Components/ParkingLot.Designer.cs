namespace ParkingLotManagement.Components
{
    partial class ParkingLot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lotDescriptionsButton = new System.Windows.Forms.Button();
            this.lotNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lotDescriptionsButton
            // 
            this.lotDescriptionsButton.BackColor = System.Drawing.Color.Green;
            this.lotDescriptionsButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.lotDescriptionsButton.FlatAppearance.BorderSize = 0;
            this.lotDescriptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lotDescriptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lotDescriptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotDescriptionsButton.ForeColor = System.Drawing.Color.White;
            this.lotDescriptionsButton.Location = new System.Drawing.Point(0, 31);
            this.lotDescriptionsButton.Name = "lotDescriptionsButton";
            this.lotDescriptionsButton.Size = new System.Drawing.Size(165, 84);
            this.lotDescriptionsButton.TabIndex = 0;
            this.lotDescriptionsButton.Text = "AVAILABLE";
            this.lotDescriptionsButton.UseVisualStyleBackColor = false;
            // 
            // lotNameLabel
            // 
            this.lotNameLabel.AutoSize = true;
            this.lotNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotNameLabel.ForeColor = System.Drawing.Color.White;
            this.lotNameLabel.Location = new System.Drawing.Point(64, 7);
            this.lotNameLabel.Name = "lotNameLabel";
            this.lotNameLabel.Size = new System.Drawing.Size(39, 15);
            this.lotNameLabel.TabIndex = 1;
            this.lotNameLabel.Text = "Lot 1";
            this.lotNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.lotNameLabel);
            this.Controls.Add(this.lotDescriptionsButton);
            this.Name = "ParkingLot";
            this.Size = new System.Drawing.Size(165, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lotDescriptionsButton;
        private System.Windows.Forms.Label lotNameLabel;
    }
}
