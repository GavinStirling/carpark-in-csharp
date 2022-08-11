using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Van : Vehicle
    {
        public Van(int id) : base("van", 3, id)
        {
        }
    }
}
