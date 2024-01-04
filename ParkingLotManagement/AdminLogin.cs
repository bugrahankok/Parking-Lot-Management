using System;
using System.Data;
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
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
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
                    ParkingLots adminWindow = new ParkingLots();
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", GlobalConstants.APP_TITLE);
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
