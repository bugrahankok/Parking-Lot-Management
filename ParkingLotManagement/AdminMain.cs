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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void ShowParkingLotsOnclick(object sender, EventArgs e)
        {
            ParkingLots parkingLots = new ParkingLots();
            parkingLots.Show();
        }

        private void LogOutOnclick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageParkingLotsOnclick(object sender, EventArgs e)
        {
            ManageParkingLots manageParkingLot = new ManageParkingLots();
            manageParkingLot.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAdminButton_Click(object sender, EventArgs e)
        {

        }
    }
}
