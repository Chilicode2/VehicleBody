using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBody
{
    public class Vehicle 
    {
        private double _speed;
        private double _weight;
        private int _occupants;
        public Vehicle(double Speed, double Weight, int Occupants)
        {
            _speed = Speed;
            _weight = Weight;
            _occupants = Occupants;
        }

        public void Steering()
        {

        }

        public void Acceleration()
        {

        }
    }
}