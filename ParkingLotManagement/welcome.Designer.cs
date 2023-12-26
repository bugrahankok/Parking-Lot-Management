namespace ParkingLotManagement
{
    partial class welcome
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
            this.enter_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blueFloorRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowFloorRadioButton = new System.Windows.Forms.RadioButton();
            this.purpleFloorRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plateTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(40, 252);
            this.enter_btn.Margin = new System.Windows.Forms.Padding(2);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(95, 38);
            this.enter_btn.TabIndex = 1;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.EnterButtonClick);
            this.exit_btn.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "FLOOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = global::ParkingLotManagement.Properties.Resources._299105_lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(255, 252);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pictureBox1.Size = new System.Drawing.Size(32, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.AdminLoginClick);
            // 
            // blueFloorRadioButton
            // 
            this.blueFloorRadioButton.AutoSize = true;
            this.blueFloorRadioButton.Checked = true;
            this.blueFloorRadioButton.Location = new System.Drawing.Point(40, 217);
            this.blueFloorRadioButton.Name = "blueFloorRadioButton";
            this.blueFloorRadioButton.Size = new System.Drawing.Size(72, 17);
            this.blueFloorRadioButton.TabIndex = 6;
            this.blueFloorRadioButton.TabStop = true;
            this.blueFloorRadioButton.Text = "Blue Floor";
            this.blueFloorRadioButton.UseVisualStyleBackColor = true;
            // 
            // yellowFloorRadioButton
            // 
            this.yellowFloorRadioButton.AutoSize = true;
            this.yellowFloorRadioButton.Location = new System.Drawing.Point(118, 217);
            this.yellowFloorRadioButton.Name = "yellowFloorRadioButton";
            this.yellowFloorRadioButton.Size = new System.Drawing.Size(82, 17);
            this.yellowFloorRadioButton.TabIndex = 7;
            this.yellowFloorRadioButton.Text = "Yellow Floor";
            this.yellowFloorRadioButton.UseVisualStyleBackColor = true;
            // 
            // purpleFloorRadioButton
            // 
            this.purpleFloorRadioButton.AutoSize = true;
            this.purpleFloorRadioButton.Location = new System.Drawing.Point(206, 217);
            this.purpleFloorRadioButton.Name = "purpleFloorRadioButton";
            this.purpleFloorRadioButton.Size = new System.Drawing.Size(81, 17);
            this.purpleFloorRadioButton.TabIndex = 8;
            this.purpleFloorRadioButton.Text = "Purple Floor";
            this.purpleFloorRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "ZLOTY CAR PARK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(341, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 161);
            this.label3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE LIST";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 152);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label6.Size = new System.Drawing.Size(151, 138);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blue Floor\r\n1 Hour = $5\r\n\r\nYellow Floor\r\n1 Hour = $4\r\n\r\nPurple Floor\r\n1 Hour = $3" +
    "";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plateTextBox
            // 
            this.plateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateTextBox.Location = new System.Drawing.Point(40, 151);
            this.plateTextBox.Name = "plateTextBox";
            this.plateTextBox.Size = new System.Drawing.Size(247, 26);
            this.plateTextBox.TabIndex = 13;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(556, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(149, 252);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(95, 38);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(589, 329);
            this.ControlBox = false;
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.plateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purpleFloorRadioButton);
            this.Controls.Add(this.yellowFloorRadioButton);
            this.Controls.Add(this.blueFloorRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton blueFloorRadioButton;
        private System.Windows.Forms.RadioButton yellowFloorRadioButton;
        private System.Windows.Forms.RadioButton purpleFloorRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox plateTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}

