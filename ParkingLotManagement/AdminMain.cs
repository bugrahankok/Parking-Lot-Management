using System;
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
            ParkingFloors parkingFloors = new ParkingFloors();
            parkingFloors.Show();
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

        private void editAdminButton_Click(object sender, EventArgs e)
        {
            AdminEdit adminEdit = new AdminEdit();
            adminEdit.Show();
        }
    }
}
