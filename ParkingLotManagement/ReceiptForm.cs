using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class ReceiptForm : Form
    {

        private readonly string DASHES = "----------------------------------------------------------------------------";

        public ReceiptForm(List<string> initData)
        {
            InitializeComponent();
            string exitDate = DateTime.Now.ToString(GlobalConstants.DATE_FORMAT);
            decimal taxRate = 8 / 100m;
            decimal taxAmount = int.Parse(initData[1]) * taxRate;

            receiptBox.Clear();
            receiptBox.AppendText(DASHES + Environment.NewLine);
            receiptBox.AppendText(DASHES + Environment.NewLine);
            receiptBox.AppendText(Environment.NewLine + Environment.NewLine);
            receiptBox.AppendText("Zloty Car Park" + Environment.NewLine);
            receiptBox.AppendText("Ul. Jana Pawła II, 01-100, 188-119-380" + Environment.NewLine);
            receiptBox.AppendText("Warsaw, Poland" + Environment.NewLine);
            receiptBox.AppendText(Environment.NewLine);
            receiptBox.AppendText(DASHES + Environment.NewLine);
            receiptBox.AppendText(DASHES + Environment.NewLine);
            receiptBox.AppendText(Environment.NewLine);
            receiptBox.AppendText($"Plate: \t {initData[3],-24}" + Environment.NewLine);
            receiptBox.AppendText($"Stayed: \t {initData[0],-24}" + Environment.NewLine);
            receiptBox.AppendText($"Entrance: \t {initData[2],-24}" + Environment.NewLine);
            receiptBox.AppendText($"Exit Date: \t {exitDate,-24}" + Environment.NewLine);
            receiptBox.AppendText($"Price: \t {initData[1],-24}" + Environment.NewLine);
            receiptBox.AppendText($"Tax ({taxRate * 100}%): \t {taxAmount,-24:F2}" + Environment.NewLine);
            receiptBox.AppendText(Environment.NewLine);
            receiptBox.AppendText(DASHES + Environment.NewLine);
            receiptBox.AppendText(DASHES + Environment.NewLine);
        }
    }
}
