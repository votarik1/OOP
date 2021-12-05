using System;
using Buildings;
using HomeWorkDLL;
namespace Main
{
    class Program
    {
        private static Logger _logger = new ConsoleLogger();
        
        static void Main(string[] args)
        {
            Building firstBuilding = Creator.CreateBuild(7);
            Building secondBuilding = Creator.CreateBuild(15, 5);
            Building thirdBuilding = Creator.CreateBuild(40, 13, 96, 3);
            Building[] buildings = new Building[] {firstBuilding,thirdBuilding};
            Creator.SaveBuilding(secondBuilding);
            Creator.Print();
            Creator.SaveBuildings(buildings);
            Creator.DeleteBuilding(1);            
            firstBuilding.High = 90;
            Creator.Print();
            
            _logger.PrintMsg("*******************************");
            secondBuilding.Print();
            _logger.PrintMsg($"Высота этажа {secondBuilding.GetFloorHigh()}");
            _logger.PrintMsg($"Количество квартир в подъезде {secondBuilding.GetNumberOfFlatsInEntrance()}");
            _logger.PrintMsg($"Количество квартир на этаже {secondBuilding.GetNumberOfFlatsOnFloor()}");
            Console.ReadKey();
        }
    }
}
