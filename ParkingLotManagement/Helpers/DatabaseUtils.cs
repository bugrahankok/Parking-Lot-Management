namespace ParkingLotManagement
{
    internal static class DatabaseUtils
    {
        public static string DATABASE_PATH = "parklotdata.db";
        public static string CONNECTION_STRING = $"Data Source={DATABASE_PATH};Version=3;";
    }
}
