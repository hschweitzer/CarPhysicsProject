using System;
using System.Collections.Generic;
using System.Text;

namespace CarPhysicsProject
{
    class SurfaceType
    {
        public string Name { get; }
        public double BaseResistance { get; set; }
        public double BaseGrip { get; set; }

        public SurfaceType(string name, double baseResistance, double baseGrip)
        {
            Name = name;
            BaseResistance = baseResistance;
            BaseGrip = baseGrip;
        }
    }
}
