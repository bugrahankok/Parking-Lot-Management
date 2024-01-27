using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.lotNameLabel.Text = lotName;
            this.lotDescriptionsButton.Text = String.Join("\n", lotDescriptions);
            this.lotDescriptionsButton.BackColor = lotDescriptions.Count > 1 ? Color.IndianRed : Color.Green;
        }
    }
}
