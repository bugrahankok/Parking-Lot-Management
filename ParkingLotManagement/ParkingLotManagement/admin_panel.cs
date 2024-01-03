using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ParkingLotManagement
{
    public partial class admin_panel : Form
    {

        public admin_panel()
        {
            InitializeComponent();
            UpdateSlots();
        }

        private void UpdateSlots()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.connectionString))
            {
                conn.Open();
                string query = @"SELECT floor, spot, plate, date FROM parkinglot WHERE occupied=1";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    string spotName = GenerateSpotName(rd[0], rd[1]);
                    Control[] spot = floorsTab.Controls.Find(spotName, true);

                    if (spot != null && spot[0] != null)
                    {

                        string plate = rd[2].ToString();
                        string date = rd[3].ToString();
                        Control targetSpot = spot[0];

                        targetSpot.BackColor = Color.DarkRed;
                        targetSpot.ForeColor = Color.White;
                        targetSpot.Text = plate + "\n" + date;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
        }

        private string GenerateSpotName(object floorName, object spot)
        {
            return floorName.ToString() + spot.ToString();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
