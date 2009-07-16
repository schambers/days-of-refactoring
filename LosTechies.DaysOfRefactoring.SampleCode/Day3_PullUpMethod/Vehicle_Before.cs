namespace LosTechies.DaysOfRefactoring.PullUpMethod.Before
{
	public abstract class Vehicle
	{
		// other methods
	}

	public class Car : Vehicle
	{
		public void Turn(Direction direction)
		{
			// code here
		}
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
