using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkDLL;

namespace Buildings
{
    public class Building
    {
        private static Logger _logger = new ConsoleLogger();
        private static int NextID = 0;
        protected int _id;
        private double _high;
        private int _numberOfFloors;
        private int _numberOfFlats;
        private int _numberOfEntrance;
        public int ID { get => _id;}
        public double High { get => _high; set => _high = value; }
        public int NumberOfFloors { get => _numberOfFloors; set => _numberOfFloors = value; }
        public int NumberOfFlats { get => _numberOfFlats; set => _numberOfFlats = value; }
        public int NumberOfEntrance { get => _numberOfEntrance; set => _numberOfEntrance = value; }
        internal Building()
        {

        }
        internal Building(double high, int numberOfFloors, int numberOfFlats, int numberOfEntrance)
        {
            _id = NextID;
            NextID++;
            High = high;
            NumberOfFloors = numberOfFloors;
            NumberOfFlats = numberOfFlats;
            NumberOfEntrance = numberOfEntrance;
        }

        public double GetFloorHigh()
        {
            return High / NumberOfFloors;
        }
        public int GetNumberOfFlatsInEntrance()
        {
            return NumberOfFlats / NumberOfEntrance;
        }
        public int GetNumberOfFlatsOnFloor()
        {
            return NumberOfFlats / NumberOfEntrance /NumberOfFloors;
        }
        public void Print()
        {
            _logger.PrintMsg($"ID: {ID}");
            _logger.PrintMsg($"High: {High}");
            _logger.PrintMsg($"Number of Floors: {NumberOfFloors}");
            _logger.PrintMsg($"Number of Entrances: {NumberOfEntrance}");
            _logger.PrintMsg($"Number of Flats: {NumberOfFlats}");
        }
    }
}
