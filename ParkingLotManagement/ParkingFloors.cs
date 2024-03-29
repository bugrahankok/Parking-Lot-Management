﻿using ParkingLotManagement.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class ParkingFloors : Form
    {
        private List<Floor> floors = new List<Floor>();
        private List<Car> cars = new List<Car>();

        public ParkingFloors()
        {
            InitializeComponent();
            GetFloors();
            GenerateFloor();
        }

        private void GetFloors()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT * FROM floor";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = rd.GetInt32(0);
                    string floorName = rd.GetString(1);
                    int lotCount = rd.GetInt32(2);
                    int hourPrice = rd.GetInt32(3);

                    Floor floor = new Floor(id, floorName, lotCount, hourPrice);
                    floors.Add(floor);
                }
            }
        }

        private void GenerateFloor()
        {
            floorsTab.TabPages.Clear();
            foreach (var floor in floors)
            {
                FlowLayoutPanel flowPanel = new FlowLayoutPanel
                {
                    AutoScroll = true,
                    Width = 995,
                    Height = 406,
                    Dock = DockStyle.Fill,
                    WrapContents = true,
                    Padding = new Padding(5, 0, 5, 0)
                };
                List<ParkingLot> parkingLots = GenerateLots(floor.getLotCount(), floor.getName());
                parkingLots.ForEach(parkingLot => { flowPanel.Controls.Add(parkingLot); });

                TabPage tab = new TabPage
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43))))),
                    BorderStyle = BorderStyle.Fixed3D,
                    Padding = new Padding(3),
                    Width = 995,
                    Height = 406,
                    TabIndex = 0,
                    Text = "  " + floor.getName() + " Floor  "
                };
                tab.Controls.Add(flowPanel);

                floorsTab.TabPages.Add(tab);
            }
        }

        private List<ParkingLot> GenerateLots(int lotCount, string floorName)
        {
            List<ParkingLot> parkingLots = new List<ParkingLot>();
            GetParkedCars(floorName);

            for (int i = 1; i <= lotCount; i++)
            {
                string lotName = floorName + " " + i;
                List<string> lotDescription = new List<string>();
                
                if (cars.Count >= i)
                {
                    Car car = cars.ElementAt(i - 1);
                    string priceLine = PriceCalculator.Calculate(car.getFloor(), car.getDate()) + " " + GlobalConstants.POLISH_ZLOTY;
                    lotDescription.Add(car.getPlate());
                    lotDescription.Add(car.getDate());
                    lotDescription.Add(priceLine);
                } else
                {
                    lotDescription.Add(GlobalConstants.AVAILABLE);
                }

                ParkingLot parkingLot = new ParkingLot(lotName, lotDescription)
                {
                    Width = 180,
                    Height = 145
                };
                parkingLots.Add(parkingLot);
            }
            return parkingLots;
        }

        private void GetParkedCars(string floorName)
        {
            cars.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                conn.Open();
                string query = @"SELECT id, floor, plate, date FROM lot WHERE floor = :floor";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add("floor", DbType.String).Value = floorName;
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = rd.GetInt32(0);
                    string floor = rd.GetString(1);
                    string plate = rd.GetString(2);
                    string date = rd.GetString(3);

                    cars.Add(new Car(id, floor, plate, date));
                }
            }
        }

    }
}
