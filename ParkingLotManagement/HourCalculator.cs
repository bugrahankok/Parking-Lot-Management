using System;

namespace ParkingLotManagement
{
    internal static class HourCalculator
    {
        public static int Calculate(string enteranceDate)
        {

            DateTime enteranceDateTime = DateTime.ParseExact(enteranceDate, GlobalConstants.DATE_FORMAT, System.Globalization.CultureInfo.CurrentCulture);
            TimeSpan diffrence = DateTime.Now - enteranceDateTime;

            return (diffrence.Days * GlobalConstants.HOURS_IN_DAY) + diffrence.Hours;
        }
    }
}
