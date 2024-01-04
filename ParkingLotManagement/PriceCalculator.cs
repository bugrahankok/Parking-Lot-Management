
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
            if (floor == "Blue")
            { return 5; }
            else if (floor == "Yellow")
            { return 4; }
            else if (floor == "Purple")
            { return 3; }

            return 0;
        }
    }
}
