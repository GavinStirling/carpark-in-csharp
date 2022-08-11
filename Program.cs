using CarPark.Vehicles;
using CarPark.Commands;
namespace CarPark
{
    class Program
    {
        public static void Main (string[] args)
        {
            CarParkCommands carparkCommands = new CarParkCommands();
            carparkCommands.run();
            
        }
    }
}