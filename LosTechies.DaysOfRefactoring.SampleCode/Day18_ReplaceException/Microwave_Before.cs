namespace LosTechies.DaysOfRefactoring.ReplaceException.Before
{
	public class Microwave
	{
		private IMicrowaveMotor Motor { get; set;}

		public bool Start(object food)
		{
			bool foodCooked = false;
			try
			{
				Motor.Cook(food);
				foodCooked = true;
			}
			catch(InUseException)
			{
				foodcooked = false;
			}

			return foodCooked;
		}
	}
}
