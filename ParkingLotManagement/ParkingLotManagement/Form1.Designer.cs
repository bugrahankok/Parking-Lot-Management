namespace ParkingLotManagement
{
    partial class form1
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
            this.cls_btn = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.plate_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.floor_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cls_btn
            // 
            this.cls_btn.BackColor = System.Drawing.Color.Red;
            this.cls_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cls_btn.Location = new System.Drawing.Point(598, 2);
            this.cls_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cls_btn.Name = "cls_btn";
            this.cls_btn.Size = new System.Drawing.Size(25, 18);
            this.cls_btn.TabIndex = 0;
            this.cls_btn.Text = "X";
            this.cls_btn.UseVisualStyleBackColor = false;
            this.cls_btn.Click += new System.EventHandler(this.cls_btn_Click);
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.Black;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_btn.Location = new System.Drawing.Point(10, 236);
            this.enter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(300, 66);
            this.enter_btn.TabIndex = 1;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Black;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Location = new System.Drawing.Point(314, 236);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(300, 66);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            // 
            // plate_box
            // 
            this.plate_box.Location = new System.Drawing.Point(176, 130);
            this.plate_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plate_box.Name = "plate_box";
            this.plate_box.Size = new System.Drawing.Size(302, 20);
            this.plate_box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plate Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "BURAYA PRICE LIST!";
            // 
            // floor_box
            // 
            this.floor_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor_box.FormattingEnabled = true;
            this.floor_box.Items.AddRange(new object[] {
            "Blue",
            "Yellow",
            "Purple"});
            this.floor_box.Location = new System.Drawing.Point(272, 162);
            this.floor_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.floor_box.Name = "floor_box";
            this.floor_box.Size = new System.Drawing.Size(94, 21);
            this.floor_box.TabIndex = 6;
            this.floor_box.SelectedIndexChanged += new System.EventHandler(this.floor_box_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Floor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingLotManagement.Properties.Resources._299105_lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(2, 339);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(623, 382);
            this.ControlBox = false;
            this.Controls.Add(this.floor_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plate_box);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.cls_btn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cls_btn;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox plate_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox floor_box;
        private System.Windows.Forms.Label label4;
    }
}

