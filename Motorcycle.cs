using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		
		
		public string Has2Wheels {get; set;}
		public string HasNoDoors {get; set;}
		public override void DriveAbstract()
		{
			Console.WriteLine($"Im riding tis motorcycle that has {Has2Wheels} and {HasNoDoors}.");
		}
		public override void DriveVirtual()
		{
			base.DriveVirtual();
		}
		
	}
}

