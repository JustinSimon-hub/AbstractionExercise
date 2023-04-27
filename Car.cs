using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}
		public override void DriveAbstract()
		{
			Console.WriteLine("This car is using the abstract method");
		}
		public override void DriveVirtual()
		{
			base.DriveVirtual();
		}


		private string carMileage {get; set;} = "Car defualt mileage";
		public string CarMileage
		{
				get{ return carMileage;}
				set{carMileage = value; }
		}
	}
}



/* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

