using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        private void LoginButtonClick(object sender, EventArgs e)
        {
            bool isLoginSuccessful = false;

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT COUNT(id) FROM admin WHERE username = :username AND password = :password";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("password", passwordTextBox.Text);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd.GetInt32(0) > 0)
                    {
                        isLoginSuccessful = true;
                    }
                }
            }

            if (isLoginSuccessful)
            {
                AdminMain adminWindow = new AdminMain();
                adminWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", GlobalConstants.APP_TITLE);
            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
