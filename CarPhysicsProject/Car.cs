using System;
using System.Collections.Generic;
using System.Text;

namespace CarPhysicsProject
{
    class Car
    {
        public string Name { get; set; }
        public double AirSpeed { get; set; }
        public double SpeedAngle { get; set; }
        public double Power { get; set; }
        public double Weight { get; set; }
        public List<Tire> Tires = new List<Tire>();

        public Car(string name, double power, double weight, List<Tire> tires)
        {
            Name = name;
            Power = power;
            Weight = weight;
            Tires = tires;
            AirSpeed = 0;
            SpeedAngle = 0;
        }

        public void getInfo()
        {
            Console.WriteLine($"Car {Name} ({Power}HP {Weight}KG)");
        }

        public void getStats()
        {
            Console.WriteLine($"AirSpeed {AirSpeed} | SpeedAngle {SpeedAngle}");
        }
    }
}
