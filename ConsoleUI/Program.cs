using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public abstract class Vehicle
        {
            public Vehicle()
            {
                Console.WriteLine("Base class constructor");
            }
            public string Year { get; set; } = "2020";
            public string Make { get; set; } = "Chevy";
            public string Model { get; set; } = "Impala";
            public abstract void DriveAbstract();
            public virtual void DriveVirtual()
            {
                Console.WriteLine("This is a virtual drive");
            }
        }

        public class Car : Vehicle
        {
            public Car()
            {
                Console.WriteLine("Car class constructor");
            }
            public bool HasTrunk { get; set; }

            public override void DriveAbstract()
            {
                Console.WriteLine("This is an abstract drive in my car");
            }
        }
        public class Motorcycle : Vehicle
        {
            public Motorcycle()
            {
                Console.WriteLine("Motorcycle class constructor");
            }
            public bool HasSideCart { get; set; }

            public override void DriveAbstract()
            {
                Console.WriteLine("This is an abstract drive on my bike");
            }
            public override void DriveVirtual()
            {
                Console.WriteLine("This is a virtual drive on my bike");
            }
        }
       
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */
            var vehicles = new List<Vehicle>();

            var myCar = new Car()
            { 
                Year = "2018",
                Make = "Ford",
                Model = "Focus",
                HasTrunk = true
            };
            vehicles.Add(myCar);

            var myBike = new Motorcycle()
            { 
                Year = "2011",
                Make = "Honda",
                Model = "Dirtbike",
                HasSideCart = false
            };
            vehicles.Add(myBike);

            Vehicle vehicle1 = new Car()
            { 
                Year = "2012",
                Make = "Crysler",
                Model = "PT Cruiser",
                HasTrunk = false
            };
            vehicles.Add(vehicle1);

            Vehicle vehicle2 = new Motorcycle()
            { 
                Year = "2009",
                Make = "Harley",
                Model = "Cross-Country",
                HasSideCart = false
            };
            vehicles.Add(vehicle2);

            Console.WriteLine("\nHere is a description of each vehicle in the list:");
            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}, which is a {item.GetType()}");
            }

            Console.WriteLine("\nNow for the abstract and virtual drives for a car and motorcycle:");
            vehicle1.DriveAbstract();
            vehicle1.DriveVirtual();
            myBike.DriveAbstract();
            myBike.DriveVirtual();

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
