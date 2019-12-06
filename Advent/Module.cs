using System;
using System.Collections.Generic;
using System.Text;

namespace Advent
{
    public class Module
    {
        public decimal Mass { get; set; }
        public int TotalFuelRequirement => CalculateFuelRequirement(Mass);

        public int CalculateFuelRequirement(decimal mass)
        {
            var fuel = FuelForMass(mass);

            var fuelFuel = FuelForMass(fuel);

            while(fuelFuel > 0)
            {
                if (fuelFuel > 0)
                {
                    fuel += fuelFuel;
                    fuelFuel = FuelForMass(fuelFuel);
                }
            }

            return fuel;
        }

        public int FuelForMass(decimal mass)
        {
            return (int)(Math.Floor(mass / 3m) - 2);
        }
    }
}
