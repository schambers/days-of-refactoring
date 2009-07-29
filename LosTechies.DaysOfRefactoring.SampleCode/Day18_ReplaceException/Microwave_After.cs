namespace LosTechies.DaysOfRefactoring.ReplaceException.After
{
	public class Microwave
	{
		private IMicrowaveMotor Motor { get; set; }

		public bool Start(object food)
		{
			if (Motor.IsInUse)
				return false;

			Motor.Cook(food);

			return true;
		}
	}
}
