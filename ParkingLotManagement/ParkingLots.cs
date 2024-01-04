using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Collections.Generic;

namespace ParkingLotManagement
{
    public partial class ParkingLots : Form
    {
        public ParkingLots()
        {
            InitializeComponent();
            UpdateSlots();
        }

        private void UpdateSlots()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
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

                        targetSpot.Enabled = true;
                        targetSpot.BackColor = Color.DarkRed;
                        targetSpot.ForeColor = Color.White;
                        targetSpot.Text = plate + "\n" + date;

                    }
                    else
                    {
                        Console.WriteLine("Error", GlobalConstants.APP_TITLE);
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

        private void ShowPrice(string plate)
        {

            List<string> carInfo = FindCar(plate);
            string enteranceDate = carInfo[0];
            string floor = carInfo[1];

            int price = PriceCalculator.Calculate(floor, enteranceDate);
            int hours = HourCalculator.Calculate(enteranceDate);

            MessageBox.Show($"Price: {price}\nHours: {hours}", GlobalConstants.APP_TITLE);

        }

        private List<string> FindCar(string plate)
        {
            List<string> car = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                string query = @"SELECT date, floor FROM parkinglot WHERE plate = :plate";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add("plate", DbType.String).Value = plate;
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    car.Add(rd[0].ToString());
                    car.Add(rd[1].ToString());
                }
            }
            return car;
        }

        private void Blue1_Click(object sender, EventArgs e)
        {
            string[] separated = Blue1.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue2_Click(object sender, EventArgs e)
        {
            string[] separated = Blue2.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue3_Click(object sender, EventArgs e)
        {
            string[] separated = Blue3.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue4_Click(object sender, EventArgs e)
        {
            string[] separated = Blue4.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue5_Click(object sender, EventArgs e)
        {
            string[] separated = Blue5.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue6_Click(object sender, EventArgs e)
        {
            string[] separated = Blue6.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue7_Click(object sender, EventArgs e)
        {
            string[] separated = Blue7.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue8_Click(object sender, EventArgs e)
        {
            string[] separated = Blue8.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue9_Click(object sender, EventArgs e)
        {
            string[] separated = Blue9.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Blue10_Click(object sender, EventArgs e)
        {
            string[] separated = Blue10.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow1_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow1.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow2_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow2.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow3_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow3.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow4_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow4.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow5_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow5.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow6_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow6.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow7_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow7.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow8_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow8.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow9_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow9.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Yellow10_Click(object sender, EventArgs e)
        {
            string[] separated = Yellow10.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple1_Click(object sender, EventArgs e)
        {
            string[] separated = Purple1.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple2_Click(object sender, EventArgs e)
        {
            string[] separated = Purple2.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple3_Click(object sender, EventArgs e)
        {
            string[] separated = Purple3.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple4_Click(object sender, EventArgs e)
        {
            string[] separated = Purple4.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple5_Click(object sender, EventArgs e)
        {
            string[] separated = Purple5.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple6_Click(object sender, EventArgs e)
        {
            string[] separated = Purple6.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple7_Click(object sender, EventArgs e)
        {
            string[] separated = Purple7.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple8_Click(object sender, EventArgs e)
        {
            string[] separated = Purple8.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple9_Click(object sender, EventArgs e)
        {
            string[] separated = Purple9.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }

        private void Purple10_Click(object sender, EventArgs e)
        {
            string[] separated = Purple10.Text.Split(':');
            string plate = separated[0];
            ShowPrice(plate);
        }
    }
}
