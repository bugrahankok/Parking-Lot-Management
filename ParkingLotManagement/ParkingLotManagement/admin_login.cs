using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class admin_login : Form
    {
        public static string databasePath = "parklotdata.db";
        public static string connectionString = $"Data Source={databasePath};Version=3;";
        public admin_login()
        {
            InitializeComponent();
        }

        private void cls_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM admin WHERE username= @user AND password= @pwd";
 
                conn.Open();
           
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
               
                cmd.Parameters.AddWithValue("@user", usrnm_box.Text);
                cmd.Parameters.AddWithValue("@pwd", pwd_box.Text);
                
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You are logged in","Logged in");
                    admin_panel ap = new admin_panel();
                    ap.Show();
                }

                else
                {
                    MessageBox.Show("Invalid username or password!","Error");
                }


                conn.Close();
            }
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
