using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}
		public string Has4Wheels {get; set;}
		public string Has4Doors {get; set;}
		public override void DriveAbstract()
		{
			Console.WriteLine($"I drivin this car that has {Has4Wheels} and {Has4Doors}");
		}
		public override void DriveVirtual()
		{
			base.DriveVirtual();
		}
	}
}

