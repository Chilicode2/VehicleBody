using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBody
{
    public class Cars : Vehicle
    {
        private int _doors;
        private float _luggage;
        public Cars(int Doors, float Luggage, int Occupants, double Speed, double Weight) : base(Speed, Weight, Occupants)
        {
            _doors = Doors;
            _luggage = Luggage;
        }

        public void doorMode()
        {

        }
    }
}