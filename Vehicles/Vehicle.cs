using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Vehicle
    {
        private string type;
        private int size;
        private int id;

        public Vehicle (string type, int size, int id)
        {
            this.type = type;
            this.size = size;
            this.id = id;
        }

        public string getType ()
        {
            return type;
        }

        public void setType (string type)
        {
            this.type = type;
        }

        public string Type { get; set; }

        public int getSize ()
        {
            return size;
        }

        public void setSize (int size)
        {
            this.size = size;
        }

        public int Size { get; set; }

        public int getId ()
        {
            return id;
        }

        public void setId (int id)
        {
            this.id = id;
        }

        public int Id { get; set; }
    }
}
