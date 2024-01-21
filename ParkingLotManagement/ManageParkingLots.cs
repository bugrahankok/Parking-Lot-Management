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
    public partial class ManageParkingLots : Form
    {
        private List<KeyValuePair<int, string>> floorsForComboBox = new List<KeyValuePair<int, string>>();
        private List<Floor> floors = new List<Floor>();

        public ManageParkingLots()
        {
            InitializeComponent();
            GetFloors();
            ShowFloorInComboBox();
        }

        private void ShowFloorInComboBox()
        {
            floorsForComboBox.ForEach(floorItem =>
            {
                this.floorComboBox.Items.Add(floorItem);
            });
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetFloors()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT * FROM floors";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = Int32.Parse(rd[0].ToString());
                    string floorName = rd[1].ToString();
                    int lotCount = Int32.Parse(rd[2].ToString());
                    int hourPrice = Int32.Parse(rd[3].ToString());
                    floorsForComboBox.Add(new KeyValuePair<int, string>(id , floorName));

                    Floor floor = new Floor(id, floorName, lotCount, hourPrice);
                    floors.Add(floor);
                }
            }
        }

        private void UpdateForm(Floor floor)
        {
            this.floorComboBox.SelectedIndex = floorsForComboBox.IndexOf(new KeyValuePair<int, string>(floor.getId(), floor.getName()));
            this.lotCountInput.Text = floor.getLotCount().ToString();
            this.hourPriceInput.Text = floor.getHourPrice().ToString();
        }

        private void FloorComboBoxIndexChanged(object sender, EventArgs e)
        {
            UpdateForm(floors.ElementAt(this.floorComboBox.SelectedIndex));
        }

        private void CloseButtonOnclick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
