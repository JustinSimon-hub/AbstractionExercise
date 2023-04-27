using System;
namespace ConsoleUI
{
 	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}
		//Everything in the abstract class is like a contract that tells us every abstract method has to be implemented and included in every derived class 
		//and must have its own implementation with the override keyword unless its virtual in that case it can inherit the parent class implementation 

public override void DriveVirtual()
{
	Console.WriteLine("This motorcycle is using the virtual override");
}
public override void DriveAbstract()
{
	Console.WriteLine("This motorcycle is using the Abstract method");
}

	

//Getter and setter using encapsulation soley for the practice of using it
		private string motorCycleMileage;
			public string MotorCycleMileage 
			{
				get {return motorCycleMileage;}
				set{motorCycleMileage = value;}
			}



	}
}





/* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
