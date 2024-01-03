using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Diagnostics;


namespace ParkingLotManagement
{
    public partial class welcome : Form
    {
        public string title = "Zloty Car Park";
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
                MessageBox.Show("Please fill the form!",title);
            }
            else
            {
                bool saveResult = SaveTheCarToDatabase(plate, floor);
                if (saveResult)
                {
                    ResetForm();
                    MessageBox.Show("Car saved!", title);
                }
                else
                {
                    MessageBox.Show("Car not saved!", title);
                }
            }

        }

        
        private void ExitButtonClick(object sender, EventArgs e)
        {

            string plate = plateTextBox.Text;
            CalculatePrice(plate);

            if (plate.Trim() == "" || plate.Length <= 5)
            {
                MessageBox.Show("Please fill the form!", title);
            }
            else
            {
                bool saveResult = ExitTheCarFromDatabase(plate);
                if (saveResult)
                {
                    ResetForm();
                    MessageBox.Show("Succesfully Exit!", title);
                }
                else
                {
                    MessageBox.Show("Car not saved!", title);
                }
            }

        }

        
        private bool SaveTheCarToDatabase(string plate, string floor)
        {

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string now = DateTime.Now.ToString();
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

            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.connectionString))
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

        private void CalculatePrice(string plate)
        {
            
            string usrDate = "";
            
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.connectionString))
            {
                connection.Open();
                string query = @"SELECT date,floor FROM parkinglot WHERE plate = :plate";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add("plate", DbType.String).Value= plate;
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                 string floor = rd[1].ToString();
                 usrDate = rd[0].ToString();
                 usrDate = usrDate.Substring(0, usrDate.Length - 3);
                    try
                    {
                        DateTime targetDateTime = DateTime.ParseExact(usrDate, "MM/dd/yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        DateTime now = DateTime.Now;
                        TimeSpan diffrence = now - targetDateTime;
                        if (diffrence.Days > 0)
                        {
                            MessageBox.Show("Your plate has been blocked for exceeding 24-hour time period. Please contact with supervisor!");
                        }
                        else
                        {
                            int hours = diffrence.Hours;
                            if (floor == "Blue")
                            {
                                int price = hours * 5;
                                MessageBox.Show($"Price: {price}", title);
                            }
                            else if (floor == "Yellow")
                            {
                                int price = hours * 3;
                                MessageBox.Show($"Price: {price}", title);
                            }
                            else if (floor == "Purple")
                            {
                                int price = hours * 4;
                                MessageBox.Show($"Price: {price}", title);
                            }
                            else
                            {
                                MessageBox.Show("Error", title);
                            }
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Error", title);
                    }
                }
                
            }
        }
        private string GetSelectedFloorName()
        {
            if (blueFloorRadioButton.Checked)
            {

                return "Blue";

            }
            else if (yellowFloorRadioButton.Checked)
            {

                return "Yellow";

            }
            else if (purpleFloorRadioButton.Checked)
            {

                return "Purple";

            }
            else 
            {

                return "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
