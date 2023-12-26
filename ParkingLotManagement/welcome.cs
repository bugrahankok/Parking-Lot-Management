using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;


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
                MessageBox.Show("Please fill the form!");
            }
            else
            {
                bool saveResult = SaveTheCarToDatabase(plate, floor);
                if (saveResult)
                {
                    ResetForm();
                    MessageBox.Show("Car saved!");
                }
                else
                {
                    MessageBox.Show("Car not saved!");
                }
            }

        }

        
        private void ExitButtonClick(object sender, EventArgs e)
        {

            string plate = plateTextBox.Text;

            if (plate.Trim() == "" || plate.Length <= 5)
            {
                MessageBox.Show("Please fill the form!");
            }
            else
            {
                bool saveResult = ExitTheCarFromDatabase(plate);
                if (saveResult)
                {
                    ResetForm();
                    MessageBox.Show("Succesfully Exit!");
                }
                else
                {
                    MessageBox.Show("Car not saved!");
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
