using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(int id) : base("car", 1, id)
        {
        }
    }
}
