using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Commands
{
    internal class CarParkCommands : Commands
    {
        public CarParkCommands() : base ("Home", new string[] { "Display carpark", "Park motorcycle", "Park car", "Park van", "Display open spots", "Display total spots", "Display no. of vans", "Quit" }, "carpark")
        {

        }

        override
        public void run ()
        {
            printMessage("Welcome, please enter the amount of motorcycle spots you would like:");
            int noOfMotorCycles = getIntegerInput(10);

            printMessage("Welcome, please enter the amount of regular spots you would like:");
            int noOfRegularSpots = getIntegerInput(100);


            CarPark park = new CarPark(noOfMotorCycles, noOfRegularSpots);

            printGreeting();


            bool isActive = true;

            while (isActive)
            {
                printCommands();
                printMessage("Select a command");
                int userInput = getIntegerInput();

                switch (userInput)
                {
                    case 1:
                        park.displayCurrentCarpark();
                        break;
                    case 2:
                        park.parkVehicle("motorcycle");
                        break;
                    case 3:
                        park.parkVehicle("car");
                        break;
                    case 4:
                        park.parkVehicle("van");
                        break;
                    case 5:
                        printMessage(park.getOpenSpotsString());
                        break;
                    case 6:
                        printMessage(park.getCarparkSizeString());
                        break;
                    case 7:
                        printMessage(park.getVanCountString());
                        break;
                    case 8:
                        printMessage("Goodbye!");
                        isActive = false;
                        break;
                    default:
                        printMessage("Didn't understand, please try again!");
                        break;
                }
            }
        }
    }
}
