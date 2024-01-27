using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class ReceiptForm : Form
    {

        public ReceiptForm(List<string> initData)
        {
            InitializeComponent();
            string ExitDate = DateTime.Now.ToString(GlobalConstants.DATE_FORMAT);
            decimal taxRate = 8 / 100m;
            decimal taxAmount = int.Parse(initData[1]) * taxRate;


            receiptBox.AppendText("---------------------------------------------------------------");
            receiptBox.AppendText("---------------------------------------------------------------");
            receiptBox.AppendText(" ");
            receiptBox.AppendText(" ");
            receiptBox.AppendText("Zloty Car Park");
            receiptBox.AppendText("Ul. Jana Pawła II, 01-100, 188-119-380");
            receiptBox.AppendText("Warsaw, Poland");
            receiptBox.AppendText(" ");
            receiptBox.AppendText(" ");
            receiptBox.AppendText("---------------------------------------------------------------");
            receiptBox.AppendText("---------------------------------------------------------------");
            receiptBox.AppendText(" ");
            receiptBox.AppendText(" ");
            receiptBox.AppendText($"Plate:              {initData[3],-24}");
            receiptBox.AppendText($"Stayed:             {initData[0],-24}");
            receiptBox.AppendText($"Entrance:           {initData[2],-24}");
            receiptBox.AppendText($"Exit Date:          {ExitDate,-24}");
            receiptBox.AppendText($"Price:              {initData[1],-24}");
            receiptBox.AppendText($"Tax ({taxRate * 100}%):    {taxAmount,-24:F2}");
            receiptBox.AppendText(" ");
            receiptBox.AppendText(" ");
            receiptBox.AppendText("---------------------------------------------------------------");
            receiptBox.AppendText("---------------------------------------------------------------");
        }
    }
}
