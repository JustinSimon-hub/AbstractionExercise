using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

		public string Year {get;set;} = "2001";
		public string Make {get;set;} = " Chevy";
		public string Model {get;set;} = "Trax";

		public abstract void DriveAbstract();
		public virtual void DriveVirtual()
		{
			Console.WriteLine("This vehicle is driving virtually!");
		}
	}
}

 /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */