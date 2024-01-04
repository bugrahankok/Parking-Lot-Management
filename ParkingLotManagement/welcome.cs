using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Collections.Generic;


namespace ParkingLotManagement
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLoginClick(object sender, EventArgs e)
        {
            admin_login adminLogin = new admin_login();
            adminLogin.Show();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            admin_login adminLogin = new admin_login();
            adminLogin.Hide();
        }

        private void EnterButtonClick(object sender, EventArgs e)
        {
           
            string plate = plateTextBox.Text;
            string floor = GetSelectedFloorName();
         
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
                    MessageBox.Show("Succesfully Exit!", GlobalConstants.APP_TITLE);
                }
                else
                {
                    MessageBox.Show("The car couldn't be exitted!", GlobalConstants.APP_TITLE);
                }
                
            }

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

        
        private bool SaveTheCarToDatabase(string plate, string floor)
        {

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string now = DateTime.Now.ToString(GlobalConstants.DATE_FORMAT);
                    command.CommandText = "UPDATE parkinglot SET plate = :plate, date = :date, occupied = 1 WHERE id = (SELECT id FROM parkinglot WHERE occupied = 0 AND floor = :floor)";
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
                    command.CommandText = "UPDATE parkinglot SET plate = NULL, date = NULL, occupied = 0 WHERE plate = :plate";
                    command.Parameters.Add("plate", DbType.String).Value = plate;
                    command.ExecuteNonQuery();

                    return true;
                }
            }

        }


        private void ResetForm()
        {
            plateTextBox.ResetText();
            blueFloorRadioButton.Checked = true;
            yellowFloorRadioButton.Checked = false;
            purpleFloorRadioButton.Checked = false;
        }

        private string GetSelectedFloorName()
        {

            if (blueFloorRadioButton.Checked)
            { return "Blue"; }
            else if (yellowFloorRadioButton.Checked)
            { return "Yellow"; }
            else if (purpleFloorRadioButton.Checked)
            { return "Purple"; }
            else 
            { return ""; }
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
