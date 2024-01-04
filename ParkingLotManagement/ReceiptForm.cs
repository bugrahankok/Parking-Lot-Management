using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class ReceiptForm : Form
    {
        private List<string> data;
        public ReceiptForm(List<string>initData)
        {
            InitializeComponent();
            data = initData;
            string ExitDate = DateTime.Now.ToString();
            decimal taxRate = 8 / 100m;
            decimal taxAmount = int.Parse(initData[1]) * taxRate;

            receiptBox.Text += "---------------------------------------------------------------\r\n";
            receiptBox.Text += "                Zloty Car Park                   \r\n";
            receiptBox.Text += "      Ul. XXXXX, 01-999, XXX-XXX-XXX            \r\n";
            receiptBox.Text += "                XXXX, Warsaw                     \r\n";
            receiptBox.Text += "---------------------------------------------------------------\r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += $"Plate:              {initData[3],-24}\r\n";
            receiptBox.Text += $"Hours stayed:      {initData[0],-24}\r\n";
            receiptBox.Text += $"Entrance Date:      {initData[2],-24}\r\n";
            receiptBox.Text += $"Exit Date:          {ExitDate,-24}\r\n";
            receiptBox.Text += $"Price:              {initData[1],-24}\r\n";
            receiptBox.Text += $"Tax ({taxRate * 100}%):    {taxAmount,-24:F2}\r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += "---------------------------------------------------------------\r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += "                                                \r\n";
            receiptBox.Text += "                                                \r\n";

        }

        private void button1_Click(object sender, EventArgs e)//close button
        {
            this.Close();
        }
    }
}
