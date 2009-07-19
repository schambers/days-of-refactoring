namespace LosTechies.DaysOfRefactoring.BreakDependencies.Before
{
	public class AnimalFeedingService
	{
		private bool FoodBowlEmpty { get; set; }

		public void Feed()
		{
			if (FoodBowlEmpty)
				Feeder.ReplenishFood();

			// more code to feed the animal
		}
	}

	public static class Feeder
	{
		public static void ReplenishFood()
		{
			// fill up bowl
		}
	}
}
