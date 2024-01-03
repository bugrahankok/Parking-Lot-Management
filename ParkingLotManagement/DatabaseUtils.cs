namespace ParkingLotManagement
{
    internal static class DatabaseUtils
    {
        public static string databasePath = "parklotdata.db";
        public static string connectionString = $"Data Source={databasePath};Version=3;";
    }
}
