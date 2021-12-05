using System.Collections;
using System.Collections.Generic;
using HomeWorkDLL;

namespace Buildings
{
    public sealed class Creator
    {
        private static Hashtable _buildings = new Hashtable();
        private static Logger _logger;
        private Creator()
        {
            _logger = new ConsoleLogger();
        }


        public static bool SaveBuilding(Building building)
        {
            if (building != null && building.ID != -1 && !_buildings.ContainsKey(building.ID)) // если будет null то второй проверки не будет
            {
                _buildings.Add(building.ID, building);
                return true;
            }
            return false;
        }
        public static bool SaveBuildings(IEnumerable buildings)
        {
            foreach (Building item in buildings)
            {
                if (item == null || _buildings.ContainsKey(item.ID))
                {
                    return false;
                }
            }
            foreach (Building item in buildings)
            {
                _buildings.Add(item.ID, item);
            }
            return true;
        }
        public static Building GetBuildingByID(int Id)
        {
            if (_buildings.ContainsKey(Id))
            {
                return _buildings[Id] as Building;
            }
            else
            {
                return NullBuilding.nullBuilding;
            }

        }

        public static bool DeleteBuilding(int Id)
        {
            _buildings.Remove(Id);
            return true;
        }

        public static Building CreateBuild(double high, int numberOfFloors, int numberOfFlats, int numberOfEntrance)
        {
            if (numberOfFloors != 0 && numberOfEntrance != 0) // Чтобы методы класса Building GetNumberOfFlatsInEntrance() GetNumberOfFlatsOnFloor() не валились с DivideByZeroException
            {
                return new Building(high, numberOfFloors, numberOfFlats, numberOfEntrance);
            }

            return NullBuilding.nullBuilding;
        }

        public static Building CreateBuild(double high)
        {
            return CreateBuild(high, 1, 1, 1);
        }
        public static Building CreateBuild(double high, int numberOfFloors)
        {
            return CreateBuild(high, numberOfFloors, 1, 1);
        }
        public static void Print()
        {
            ICollection buildings = _buildings.Values;


            foreach ( var item in buildings)
            {
                ((Building)item).Print();
            }
        }
        private sealed class NullBuilding : Building
        {
            public static readonly NullBuilding nullBuilding = new NullBuilding();
            public NullBuilding()
            {
                _id = -1;
                High = 1;
                NumberOfFloors = 1;
                NumberOfFlats = 1;
                NumberOfEntrance = 1;
            }
        }







    }
}
