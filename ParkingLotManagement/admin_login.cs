using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class admin_login : Form
    {
        
        public admin_login()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.connectionString))
            {
                string query = "SELECT * FROM admin WHERE username= @user AND password= @pwd";
 
                conn.Open();
           
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
               
                cmd.Parameters.AddWithValue("@user", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@pwd", passwordTextBox.Text);
                
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    admin_panel adminWindow = new admin_panel();
                    adminWindow.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Invalid username or password!","Error");
                }

                conn.Close();
            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
