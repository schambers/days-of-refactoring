namespace LosTechies.DaysOfRefactoring.PullUpMethod.After
{
	public abstract class Vehicle
	{
		public void Turn(Direction direction)
		{
			// code here
		}
	}

	public class Car : Vehicle
	{
	}

	public class Motorcycle : Vehicle
	{
	}

	public enum Direction
	{
		Left,
		Right
	}
}
