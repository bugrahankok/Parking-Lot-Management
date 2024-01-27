using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class AdminEdit : Form
    {
        public AdminEdit()
        {
            InitializeComponent();
            GetAdminInformation();
        }

        private void GetAdminInformation()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT * FROM admin WHERE id = 1";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string username = rd[0].ToString();
                    string password = rd[1].ToString();
                    
                    usernameInput.Text = username;
                    passwordInput.Text = password;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateAdmin();
        }

        private void UpdateAdmin()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE admin SET username = :username, password = :password WHERE id = 1";
                    command.Parameters.Add("username", DbType.String).Value = usernameInput.Text;
                    command.Parameters.Add("password", DbType.String).Value = passwordInput.Text;
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Admin details are successfully updated!");
        }
    }
}
