using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBody
{
    public class Motorbike : Vehicle
    {
        private int _typeMotorbike;
        public Motorbike(int TypeMotorbike,double Speed, double Weight, int Occupants) : base(Speed, Weight, Occupants)
        {
            this._typeMotorbike = TypeMotorbike;
        }

        public void engineMode()
        {

        }
    }
}