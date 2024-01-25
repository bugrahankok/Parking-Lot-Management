
using System.Data.SQLite;
using System.Data;
using System;

namespace ParkingLotManagement
{
    internal static class PriceCalculator
    {
        public static int Calculate(string floor, string enteranceDate)
        {
            int hours = HourCalculator.Calculate(enteranceDate);
            int floorPrice = GetPriceByFloor(floor);

            if (hours <= 0)
            {
                return floorPrice;
            }
            return hours * floorPrice;
        }


        private static int GetPriceByFloor(string floor)
        {
            int price = 0;
            using (SQLiteConnection connection = new SQLiteConnection(DatabaseUtils.CONNECTION_STRING))
            {
                connection.Open();
                string query = @"SELECT hour_price FROM floors WHERE name = :name";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add("name", DbType.String).Value = floor;
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    price = Int32.Parse(rd[0].ToString());
                }
            }
            return price;
        }
    }
}
