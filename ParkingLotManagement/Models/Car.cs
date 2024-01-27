namespace ParkingLotManagement
{
    internal class Car
    {
        private int id;
        private string floor;
        private string plate;
        private string date;

        public Car(int id, string floor, string plate, string date)
        {
            this.id = id;
            this.floor = floor;
            this.plate = plate;
            this.date = date;
        }

        public int getId() { return id; }
        public string getFloor() { return floor; }
        public string getPlate() {  return plate; }
        public string getDate() { return date; }

    }
}
