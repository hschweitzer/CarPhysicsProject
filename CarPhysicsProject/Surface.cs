using System;
using System.Collections.Generic;
using System.Text;

namespace CarPhysicsProject
{
    class Surface
    {
        public string Name { get; }
        public SurfaceType SurfaceType { get; }
        public double CurrentResistance { get; set; }
        public double CurrentGrip { get; set; }

        public Surface(string name, SurfaceType surfaceType)
        {
            Name = name;
            SurfaceType = surfaceType;
            CurrentGrip = surfaceType.BaseGrip;
            CurrentResistance = surfaceType.BaseResistance;
        }

        public void getInfo()
        {
            Console.WriteLine($"Surface {Name} of type {SurfaceType.Name}");
        }

        public void getStats()
        {
            Console.WriteLine($"Resistance: {CurrentResistance} | Grip: {CurrentGrip}");
        }
    }
}
