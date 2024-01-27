using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class ManageParkingLots : Form
    {
        private List<KeyValuePair<int, string>> floorsForComboBox = new List<KeyValuePair<int, string>>();
        private List<Floor> floors = new List<Floor>();
        private string formMode = "edit";

        public ManageParkingLots()
        {
            InitializeComponent();
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            floors.Clear();
            floorsForComboBox.Clear();
            floorComboBox.Items.Clear();
            GetFloors();
            ShowFloorInComboBox();
            UpdateFormMode(formMode);
        }

        private void UpdateFormMode(string formMode)
        {
            switch (formMode)
            {
                case "edit":
                    floorNameInput.Enabled = true;
                    floorComboBox.Enabled = true;
                    lotCountInput.Enabled = true;
                    hourPriceInput.Enabled = true;
                    break;
                case "create":
                    floorNameInput.Enabled = true;
                    floorComboBox.Enabled = false;
                    lotCountInput.Enabled = true;
                    hourPriceInput.Enabled = true;
                    break;
                case "delete":
                    floorNameInput.Enabled = false;
                    floorComboBox.Enabled = true;
                    lotCountInput.Enabled = false;
                    hourPriceInput.Enabled = false;
                    break;   
            }
            this.formMode = formMode;
        }

        private void ShowFloorInComboBox()
        {
            floorsForComboBox.ForEach(floorItem =>
            {
                this.floorComboBox.Items.Add(floorItem);
            });
            floorComboBox.SelectedIndex = 0;
        }


        private void SaveForm()
        {

            int id = floorsForComboBox.ElementAt(floorComboBox.SelectedIndex).Key;
            string floorName = floorNameInput.Text;
            int lotCount = Int32.Parse(lotCountInput.Text);
            int hourPrice = Int32.Parse(hourPriceInput.Text);
            Floor floor = new Floor(id, floorName, lotCount, hourPrice);


            if (formMode == "edit")
            {
                UpdateFloor(floor);
            } else if (formMode == "create")
            {
                CreateFloor(floor);
            } else if (formMode == "delete")
            {
                DeleteFloor(id);
            }

            RefreshScreen();
        }

        private bool CreateFloor(Floor floor)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO floors (name, lot_count, hour_price) VALUES (:name, :lot_count, :hour_price)";
                    command.Parameters.Add("name", DbType.String).Value = floor.getName();
                    command.Parameters.Add("lot_count", DbType.Int32).Value = floor.getLotCount();
                    command.Parameters.Add("hour_price", DbType.Int32).Value = floor.getHourPrice();
                    command.ExecuteNonQuery();

                    return true;
                }
            }
        }

        private bool DeleteFloor(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM floors WHERE id = :id";
                    command.Parameters.Add("id", DbType.Int32).Value = id;
                    command.ExecuteNonQuery();

                    return true;
                }
            }
        }

        private bool UpdateFloor(Floor floor)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE floors SET name = :name, lot_count = :lot_count, hour_price = :hour_price WHERE id = :id";
                    command.Parameters.Add("id", DbType.Int32).Value = floor.getId();
                    command.Parameters.Add("name", DbType.String).Value = floor.getName();
                    command.Parameters.Add("lot_count", DbType.Int32).Value = floor.getLotCount();
                    command.Parameters.Add("hour_price", DbType.Int32).Value = floor.getHourPrice();
                    command.ExecuteNonQuery();

                    return true;
                }
            }
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
            this.floorNameInput.Text = floor.getName();
            this.lotCountInput.Text = floor.getLotCount().ToString();
            this.hourPriceInput.Text = floor.getHourPrice().ToString();
        }

        private void FloorComboBoxIndexChanged(object sender, EventArgs e)
        {
            UpdateForm(floors.ElementAt(this.floorComboBox.SelectedIndex));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            UpdateFormMode("create");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UpdateFormMode("edit");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UpdateFormMode("delete");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveForm();
        }
    }
}
