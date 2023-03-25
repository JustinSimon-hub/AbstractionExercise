using System;
namespace ConsoleUI
{
	 public abstract class Vehicle
	{
		
		public  string Year {get; set;} = "2001";
		public string Make {get; set;} = "Regular Make";
		public string Model {get; set;} = "Regular Model";
		public abstract void DriveAbstract();
		public virtual void DriveVirtual()
		{
			Console.WriteLine("Im driving this vehicle.");
		}
	}
}

