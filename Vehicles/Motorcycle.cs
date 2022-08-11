using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(int id) : base ("motorcycle", 1, id)
        {
        }
    }
}
