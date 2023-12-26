using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;


namespace ParkingLotManagement
{
    public partial class form1 : Form
    {
        public static string databasePath = "parklotdata.db";
        public static string connectionString = $"Data Source={databasePath};Version=3;";

        public form1()
        {
            InitializeComponent();
        }

        private void cls_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_login adl = new admin_login();
            adl.Show();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            admin_login adl = new admin_login();
            adl.Hide();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
           
            string floor = floor_box.SelectedItem.ToString();
            string plate = plate_box.Text;

         
            if (plate.Trim() == "" || floor.Trim() == "" || plate.Length <= 5)  
            {
                MessageBox.Show("Please fill the form!");
            }
            else
            {
                bool saveResult = saveTheCarToDatabase(plate, floor);
                if (saveResult)
                {
                    MessageBox.Show("Car saved!");
                } else
                {
                    MessageBox.Show("Car not saved!");
                }
            }

        }

        private void floor_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool saveTheCarToDatabase(string plate, string floor)
        {

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
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
    }

}
