using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotManagement
{
    internal class Floor
    {
        private int id;
        private string name;
        private int lotCount;
        private int hourPrice;
        
        public Floor(int id, string name, int lotCount, int hourPrice) 
        { 
            this.id = id;
            this.name = name;
            this.lotCount = lotCount;   
            this.hourPrice = hourPrice;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public int getLotCount() { return lotCount; }
        public int getHourPrice() {  return hourPrice; }
    }
}
