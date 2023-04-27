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
            List<Vehicle> listofvehicles = new List<Vehicle>();

            Vehicle moto1 = new Motorcycle(){Make = "Yamazaki", Model = "Zizi", Year = "2001", };
            Motorcycle moto2 = new Motorcycle(){Make = "Harley", Model ="Davidson XXL", Year = "2001"};
            Vehicle car1 = new Car(){Make = "Lambo", Model = "Urus", Year = "2023"};
            Car car2 = new Car();//Not setting the properties here so that the base default props. in the vehicle class will dispaly 

//Adding the objects to the list
            listofvehicles.Add(moto1);
            listofvehicles.Add(moto2);
            listofvehicles.Add(car1);
            listofvehicles.Add(car2);

            //Displaying the props. using a foreach loop
            foreach(Vehicle vehicle in listofvehicles)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Year}, {vehicle.Model}");
            }


                moto1.DriveAbstract();
                moto1.DriveVirtual();
                car1.DriveAbstract();
                car1.DriveVirtual();
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

            #endregion            
            Console.ReadLine();
        }
    }
}