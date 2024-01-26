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
            this.lotDescriptionsButton.Location = new System.Drawing.Point(14, 31);
            this.lotDescriptionsButton.Name = "lotDescriptionsButton";
            this.lotDescriptionsButton.Size = new System.Drawing.Size(167, 93);
            this.lotDescriptionsButton.TabIndex = 0;
            this.lotDescriptionsButton.Text = "button1";
            this.lotDescriptionsButton.UseVisualStyleBackColor = true;
            // 
            // lotNameLabel
            // 
            this.lotNameLabel.AutoSize = true;
            this.lotNameLabel.ForeColor = System.Drawing.Color.White;
            this.lotNameLabel.Location = new System.Drawing.Point(79, 6);
            this.lotNameLabel.Name = "lotNameLabel";
            this.lotNameLabel.Size = new System.Drawing.Size(35, 13);
            this.lotNameLabel.TabIndex = 1;
            this.lotNameLabel.Text = "label1";
            // 
            // ParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lotNameLabel);
            this.Controls.Add(this.lotDescriptionsButton);
            this.Name = "ParkingLot";
            this.Size = new System.Drawing.Size(197, 137);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lotDescriptionsButton;
        private System.Windows.Forms.Label lotNameLabel;
    }
}
