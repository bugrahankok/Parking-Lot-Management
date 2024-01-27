using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Collections.Generic;
using System.Linq;


namespace ParkingLotManagement
{
    public partial class Main : Form
    {
        private List<KeyValuePair<int, string>> floorsForComboBox = new List<KeyValuePair<int, string>>();

        public Main()
        {
            InitializeComponent();
            GetFloors();
            ShowFloorInComboBox();
            ShowPricesList();
        }

        private void GetFloors()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT * FROM floor";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = rd.GetInt32(0);
                    string floorName = rd.GetString(1);
                    floorsForComboBox.Add(new KeyValuePair<int, string>(id, floorName));
                }
            }
        }

        private void ShowFloorInComboBox()
        {
            floorsForComboBox.ForEach(floorItem =>
            {
                this.floorComboBox.Items.Add(floorItem);
            });
            floorComboBox.SelectedIndex = 0;
        }

        private void AdminLoginClick(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }


        private void EnterButtonClick(object sender, EventArgs e)
        {
           
            string plate = plateTextBox.Text;
            string floor = GetSelectedFloorName();
            bool noAvailableSpace = !CheckIsThereAnyAvailableParkingLot(floor);

            if (noAvailableSpace)
            {
                MessageBox.Show("There is no available lot in the selected floor!", GlobalConstants.APP_TITLE);
            }
         
            if (plate.Trim() == "" || plate.Length <= 5 || floor == "")  
            {
                MessageBox.Show("Please fill the form!", GlobalConstants.APP_TITLE);
            }
            else
            {
                bool saveResult = SaveTheCarToDatabase(plate, floor);
                if (saveResult)
                {
                    ResetForm();
                    MessageBox.Show("Car saved!", GlobalConstants.APP_TITLE);
                }
                else
                {
                    MessageBox.Show("Car not saved!", GlobalConstants.APP_TITLE);
                }
            }

        }

        
        private void ExitButtonClick(object sender, EventArgs e)
        {

            string plate = plateTextBox.Text;

            if (plate.Trim() == "" || plate.Length <= 5)
            {
                MessageBox.Show("Please fill the form!", GlobalConstants.APP_TITLE);
            }
            else
            {
                List<string> carInfo = FindCar(plate);
                string enteranceDate = carInfo[0];
                string floor = carInfo[1];

                int price = PriceCalculator.Calculate(floor, enteranceDate);
                int hours = HourCalculator.Calculate(enteranceDate);

                ShowReceipt(hours, price, enteranceDate, plate);

                bool result = ExitTheCarFromDatabase(plate);
                if (result)
                {
                    ResetForm();
                    MessageBox.Show("The car is succesfully exitted!", GlobalConstants.APP_TITLE);
                }
                else
                {
                    MessageBox.Show("The car couldn't be exitted!", GlobalConstants.APP_TITLE);
                }
                
            }

        }

        private bool CheckIsThereAnyAvailableParkingLot(string floorName)
        {
            int totalCarInFloor = 0;
            int floorLotCountLimit = 0;

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT COUNT(id) FROM lot WHERE floor = :floor";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add("floor", DbType.String).Value = floorName;
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    totalCarInFloor = rd.GetInt32(0);
                }
            }

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT lot_count FROM floor WHERE name = :floor";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add("floor", DbType.String).Value = floorName;
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    floorLotCountLimit = rd.GetInt32(0);
                }
            }

            return floorLotCountLimit - totalCarInFloor > 0;
        }


        private List<string> FindCar(string plate)
        {
            List<string> car = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                string query = @"SELECT date, floor FROM lot WHERE plate = :plate";
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

        private void ShowPricesList()
        {
            string pricesText = "";
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                string query = @"SELECT name, hour_price FROM floor";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string name = rd.GetString(0);
                    int price = rd.GetInt32(1);
                    pricesText = pricesText + name + " Floor" 
                                            + "\n" 
                                            + "1 Hour = " + price + " " + GlobalConstants.POLISH_ZLOTY 
                                            + "\n\n";
                }
            }
            priceListLabel.Text = pricesText;
        }

        
        private bool SaveTheCarToDatabase(string plate, string floor)
        {

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string now = DateTime.Now.ToString(GlobalConstants.DATE_FORMAT);
                    command.CommandText = "INSERT INTO lot (plate, date, floor) VALUES (:plate, :date, :floor)";
                    command.Parameters.Add("plate", DbType.String).Value = plate;
                    command.Parameters.Add("date", DbType.String).Value = now;
                    command.Parameters.Add("floor", DbType.String).Value = floor;
                    command.ExecuteNonQuery();

                    return true;
                }
            }
        }


        private bool ExitTheCarFromDatabase(string plate)
        {

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM lot WHERE plate = :plate";
                    command.Parameters.Add("plate", DbType.String).Value = plate;
                    command.ExecuteNonQuery();

                    return true;
                }
            }

        }


        private void ResetForm()
        {
            plateTextBox.ResetText();
            floorComboBox.SelectedIndex = 0;
        }

        private string GetSelectedFloorName()
        {
            return floorsForComboBox.ElementAt(floorComboBox.SelectedIndex).Value;
        }

        private void ShowReceipt(int hours, int price, string date, string plate)
        {
            List<string> data = new List<string>
            {
                hours.ToString(),
                price.ToString(),
                date,
                plate
            };
            ReceiptForm receiptForm = new ReceiptForm(data);
            receiptForm.Show();
        }
    }

}
