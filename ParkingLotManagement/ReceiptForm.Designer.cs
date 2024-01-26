namespace ParkingLotManagement
{
    partial class ReceiptForm
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
            this.receiptBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptBox
            // 
            this.receiptBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.receiptBox.Location = new System.Drawing.Point(9, 28);
            this.receiptBox.Margin = new System.Windows.Forms.Padding(2);
            this.receiptBox.Multiline = true;
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.ReadOnly = true;
            this.receiptBox.Size = new System.Drawing.Size(329, 516);
            this.receiptBox.TabIndex = 0;
            this.receiptBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.receiptBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(311, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(346, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receiptBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiptBox;
        private System.Windows.Forms.Button button1;
    }
}