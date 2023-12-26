namespace ParkingLotManagement
{
    partial class admin_login
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
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.usrnm_box = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cls_btn
            // 
            this.cls_btn.BackColor = System.Drawing.Color.Red;
            this.cls_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cls_btn.Location = new System.Drawing.Point(275, 2);
            this.cls_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cls_btn.Name = "cls_btn";
            this.cls_btn.Size = new System.Drawing.Size(23, 19);
            this.cls_btn.TabIndex = 1;
            this.cls_btn.Text = "X";
            this.cls_btn.UseVisualStyleBackColor = false;
            this.cls_btn.Click += new System.EventHandler(this.cls_btn_Click);
            // 
            // pwd_box
            // 
            this.pwd_box.Location = new System.Drawing.Point(62, 102);
            this.pwd_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pwd_box.Name = "pwd_box";
            this.pwd_box.PasswordChar = '*';
            this.pwd_box.Size = new System.Drawing.Size(171, 20);
            this.pwd_box.TabIndex = 2;
            // 
            // usrnm_box
            // 
            this.usrnm_box.Location = new System.Drawing.Point(62, 80);
            this.usrnm_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usrnm_box.Name = "usrnm_box";
            this.usrnm_box.Size = new System.Drawing.Size(171, 20);
            this.usrnm_box.TabIndex = 2;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Black;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Location = new System.Drawing.Point(62, 135);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(170, 26);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingLotManagement.Properties.Resources._299105_lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(30, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(298, 188);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.usrnm_box);
            this.Controls.Add(this.pwd_box);
            this.Controls.Add(this.cls_btn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_login";
            this.Load += new System.EventHandler(this.admin_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cls_btn;
        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.TextBox usrnm_box;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}