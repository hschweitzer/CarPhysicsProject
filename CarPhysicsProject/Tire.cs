using System;
using System.Collections.Generic;
using System.Text;

namespace CarPhysicsProject
{
    class Tire
    {
        public string Name { get; }
        public double CurrentStickiness { get; set; }
        public double CurrentDurability { get; set; }
        public double CurrentRoughness { get; set; }
        public double Angle { get; set; }
        public TireType TireType { get; }

        public Tire(string name, TireType tireType)
        {
            Name = name;
            CurrentStickiness = tireType.BaseStickiness;
            CurrentDurability = tireType.BaseDurability;
            CurrentRoughness = tireType.BaseRoughness;
            TireType = tireType;
            Angle = 0;
        }

        public void getInfo()
        {
            Console.WriteLine($"Tire {Name} of type {TireType.Name}");
        }

        public void getStats()
        {
            Console.WriteLine($"Durability: {CurrentDurability} | Stickiness: {CurrentStickiness} | Rougness: {CurrentRoughness}");
        }
    }
}
