using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

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
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
                List<Vehicle> vehicles = new List<Vehicle>();
                Vehicle vehc1 = new Car(){Year = "2001", Make = " Honda", Model = "Civic"};
                Vehicle vehc2 = new Motorcycle();
                Car car = new Car(){Year = "1997", Make = "Toyota", Model = "Prius", Has4Doors = "Has 3 doors", Has4Wheels = "Has 4 wheels"};
                Motorcycle motorcycle = new Motorcycle(){Year = "2005", Make = "Yazuka", Model = "Machimi", Has2Wheels = "Has 2 wheels", HasNoDoors = "Doesnt have doors"};
            vehicles.Add(vehc1);
            vehicles.Add(vehc2);
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            foreach ( var item in vehicles)
            {
                Console.WriteLine($"{item.Year}, {item.Model}, {item.Make}");
            }
            Console.WriteLine("*****************");
            car.DriveAbstract();
            Console.WriteLine("*********");
            car.DriveVirtual();
            Console.WriteLine("*************");
            motorcycle.DriveAbstract();
            Console.WriteLine("***********");
            motorcycle.DriveVirtual();
            #endregion            
            Console.ReadLine();
        }
    }
}
