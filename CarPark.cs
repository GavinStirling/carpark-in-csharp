using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarPark.Vehicles;

namespace CarPark
{
    internal class CarPark
    {
        private List<Vehicle> carpark;
        private int noOfMotorcycles;
        private int noOfCars;

        public CarPark (int noOfMotorcycles, int noOfCars)
        {
            carpark = new List<Vehicle>();
            
            this.noOfMotorcycles = noOfMotorcycles;
            this.noOfCars = noOfCars;


            for (int i = 0; i < noOfMotorcycles; i++)
            {
                carpark.Add(new EmptySpot("emptym", i+1));
            }
            for (int i = noOfMotorcycles; i < (noOfMotorcycles + noOfCars); i++)
            {
                carpark.Add(new EmptySpot("emptyc", i + 1));
            }
        }

        public void displayCurrentCarpark()
        {
            foreach (Vehicle vehicle in carpark)
            {
                Console.WriteLine($"\nType: {vehicle.getType()}\nID: {vehicle.getId()}");
            }
        }

        public void parkVehicle(string type)
        {
            if (getOpenSpots() > 0)
            {
                if (type.Equals("motorcycle"))
                {
                    for (int i = 0; i < getCarparkSize(); i++)
                    {
                        if (carpark[i].getType().Equals("emptym"))
                        {
                            carpark[i] = new Motorcycle(i+1);
                            break;
                        }else if (carpark[i].getType().Equals("emptyc"))
                        {
                            carpark[i] = new Motorcycle(i+1);
                            break;
                        }
                    }
                } else if (type.Equals("car"))
                {
                    for (int i = 0; i < getCarparkSize(); i++)
                    {
                        if (carpark[i].getType().Equals("emptyc"))
                        {
                            carpark[i] = new Car(i+1);
                            break;
                        } 
                    }
                }
                else if (type.Equals("van"))
                {
                    for (int i = 0; i < getCarparkSize()-2; i++)
                    {
                        if (carpark[i].getType().Equals("emptyc") && carpark[i+1].getType().Equals("emptyc") && carpark[i+2].getType().Equals("emptyc"))
                        {
                            carpark[i] = new Van(i+1);
                            carpark[i+1] = new Van(i+1);
                            carpark[i+2] = new Van(i+1);
                            break;
                        }
                    }
                }
                Console.WriteLine(checkCapacity());
            } else
            {
                Console.WriteLine("The carpark is full.");
            }
        }

        public int getOpenSpots ()
        {
            int size = 0;

            foreach (Vehicle vehicle in carpark)
            {
                if (vehicle.getType().Contains("empty"))
                {
                    size += 1;
                }
            }

            return size;
        }

        public int getOpenSpots(string type)
        {
            int size = 0;

            foreach (Vehicle vehicle in carpark)
            {
                if (vehicle.getType().Equals(type))
                {
                    size += 1;
                }
            }

            return size;
        }

        public string getOpenSpotsString ()
        {
            return $"There are {getOpenSpots()} open spots remaining.\n There are {getOpenSpots("emptym")} open motorcycle spots remaining and {getOpenSpots("emptyc")} open regular spots remaining.";
        }

        public int getCarparkSize ()
        {
            return carpark.Count;
        }

        public string getCarparkSizeString ()
        {
            return $"The carpark has {getCarparkSize()} spots in it.";
        }

        public string checkCapacity()
        {
            if (getOpenSpots() == 0)
            {
                return "The carpark is now full.";
            } else if (getOpenSpots() == getCarparkSize())
            {
                return "The carpark is empty.";
            } else if (getOpenSpots("emptym") == 0)
            {
                return "All motorcycle spots are now full.";
            } else if (getOpenSpots("emptyc") == 0)
            {
                return "All regular spots are now full.";
            } else
            {
                return "";
            }
        }

        public int vanCount ()
        {
            int noOfVans = 0;

            for (int i = 0; i < getCarparkSize() - 2; i++)
            {
                if (carpark[i].getType().Equals("van"))
                {
                    noOfVans++;
                    i += 2;
                }
            }

            return noOfVans;
        }

        public string getVanCountString ()
        {
            return $"There are a total of {vanCount()} vans in the parking lot.";
        }

    }
}
