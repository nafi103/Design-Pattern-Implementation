using System;

namespace AbstractFactoryExample
{
    // 1. The Abstract Products
    public abstract class Car 
    { 
        public abstract void Drive(); 
    }

    public abstract class Bike 
    { 
        public abstract void Ride(); 
    }

    // 2. The Concrete Products
    public class CityCar : Car 
    {
        public override void Drive() 
        {
            Console.WriteLine("Starting the quiet hybrid engine...");
            Console.WriteLine("Cruising smoothly through downtown traffic in the City Car.");
        }
    }

    public class SportsCar : Car 
    {
        public override void Drive() 
        {
            Console.WriteLine("V8 Engine roaring to life!");
            Console.WriteLine("Accelerating rapidly down the highway in the Sports Car.");
        }
    }

    public class CityBike : Bike 
    {
        public override void Ride() 
        {
            Console.WriteLine("Ringing the bicycle bell.");
            Console.WriteLine("Pedaling casually along the park trail on a City Bike.");
        }
    }

    public class SportsBike : Bike 
    {
        public override void Ride() 
        {
            Console.WriteLine("Dropping the visor and revving the throttle.");
            Console.WriteLine("Hitting the apex of the corner on the Sports Bike!");
        }
    }

    // 3. The Abstract Factory
    public abstract class VehicleFactory
    {
        public abstract Car CreateCar();
        public abstract Bike CreateBike();
    }

    // 4. The Concrete Factories
    public class CityVehicleFactory : VehicleFactory
    {
        public override Car CreateCar() => new CityCar();
        public override Bike CreateBike() => new CityBike();
    }

    public class SportsVehicleFactory : VehicleFactory
    {
        public override Car CreateCar() => new SportsCar();
        public override Bike CreateBike() => new SportsBike();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testing the Sports Factory ---");
            VehicleFactory sportsFactory = new SportsVehicleFactory(); 
            
            Car mySportsCar = sportsFactory.CreateCar();
            Bike mySportsBike = sportsFactory.CreateBike();

            mySportsCar.Drive();
            Console.WriteLine();
            mySportsBike.Ride();

            Console.WriteLine("\n--- Testing the City Factory ---");
            VehicleFactory cityFactory = new CityVehicleFactory(); 
            
            Car myCityCar = cityFactory.CreateCar();
            Bike myCityBike = cityFactory.CreateBike();

            myCityCar.Drive();
            Console.WriteLine(); 
            myCityBike.Ride();
            
            Console.ReadLine();
        }
    }
}