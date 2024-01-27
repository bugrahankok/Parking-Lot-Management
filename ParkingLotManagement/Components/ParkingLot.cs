using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingLotManagement.Components
{
    public partial class ParkingLot : UserControl
    {   
        public ParkingLot(string lotName, List<string> lotDescriptions)
        {
            InitializeComponent();
            SetTexts(lotName, lotDescriptions);
        }

        private void SetTexts(string lotName, List<string> lotDescriptions)
        {
            lotNameLabel.Text = lotName;
            lotDescriptionsButton.Text = String.Join(Environment.NewLine, lotDescriptions);
            SetColors(lotDescriptions.Count);
        }

        private void SetColors(int descriptionCount)
        {
            lotDescriptionsButton.BackColor = descriptionCount > 1 ? Color.IndianRed : Color.Green;
            lotDescriptionsButton.ForeColor = Color.White;
            lotNameLabel.ForeColor = Color.White;
        }
    }
}
