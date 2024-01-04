using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class ReceiptForm : Form
    {

        public ReceiptForm(List<string>initData)
        {
            InitializeComponent();
            string ExitDate = DateTime.Now.ToString(GlobalConstants.DATE_FORMAT);
            decimal taxRate = 8 / 100m;
            decimal taxAmount = int.Parse(initData[1]) * taxRate;

            receiptBox.Text += "---------------------------------------------------------------\r\n";
            receiptBox.Text += "                Zloty Car Park                   \r\n";
            receiptBox.Text += "      Ul. XXXXX, 01-999, XXX-XXX-XXX            \r\n";
            receiptBox.Text += "                XXXX, Warsaw                     \r\n";
            receiptBox.Text += "---------------------------------------------------------------\r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += $"Plate:              {initData[3],-24}\r\n";
            receiptBox.Text += $"Stayed:             {initData[0],-24}\r\n";
            receiptBox.Text += $"Entrance:           {initData[2],-24}\r\n";
            receiptBox.Text += $"Exit Date:          {ExitDate,-24}\r\n";
            receiptBox.Text += $"Price:              {initData[1],-24}\r\n";
            receiptBox.Text += $"Tax ({taxRate * 100}%):    {taxAmount,-24:F2}\r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += "---------------------------------------------------------------\r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += "                                                \r\n";

        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
