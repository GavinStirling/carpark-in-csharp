using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class EmptySpot : Vehicle
    {
        public EmptySpot(string type, int id) : base(type, 1, id)
        {
        }
    }
}
