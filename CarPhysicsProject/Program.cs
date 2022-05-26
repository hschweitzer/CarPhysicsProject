using System;
using System.Collections.Generic;

namespace CarPhysicsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TireType defaultTire = new TireType("Standard", 225, 16, 100, 100, 10);
            Tire frontLeft = new Tire("Front left", defaultTire);
            Tire frontRight = new Tire("Front right", defaultTire);
            Tire backLeft = new Tire("Back left", defaultTire);
            Tire backRight = new Tire("Back right", defaultTire);

            List<Tire> carTires = new List<Tire>();
            carTires.Add(frontLeft);
            carTires.Add(frontRight);
            carTires.Add(backLeft);
            carTires.Add(backRight);

            SurfaceType asphalt = new SurfaceType("Asphalt", 100, 100);
            Surface track = new Surface("Track", asphalt);

            track.getInfo();
            track.getStats();

            Car car = new Car("First car", 100, 1000, carTires);
        }

        private void Drive(Car car, Surface surface)
        {
            double initialSpeed = car.AirSpeed;


        }
    }
}
