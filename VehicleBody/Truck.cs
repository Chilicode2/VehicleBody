using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleBody
{
    public class Truck : Vehicle
    {
        private float _tonnageCapacity;
        public Truck(float TonnageCapacity, double Speed, double Weight, int Occupants) : base(Speed, Weight, Occupants)
        {
            this._tonnageCapacity = TonnageCapacity;
        }


        public void loadTonnage()
        {

        }
    }
}