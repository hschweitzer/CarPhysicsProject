using System;
using System.Collections.Generic;
using System.Text;

namespace CarPhysicsProject
{
    class TireType
    {
        public string Name { get; }
        public double Width { get; }
        public double RimDiameter { get; }
        public double BaseStickiness { get; }
        public double BaseDurability { get; }
        public double BaseRoughness { get; }

        public TireType(string name, double width, double rimDiameter, double baseStickiness, double baseDurability, double baseRoughness)
        {
            Name = name;
            Width = width;
            RimDiameter = rimDiameter;
            BaseStickiness = baseStickiness;
            BaseDurability = baseDurability;
            BaseRoughness = baseRoughness;
        }
    }
}
