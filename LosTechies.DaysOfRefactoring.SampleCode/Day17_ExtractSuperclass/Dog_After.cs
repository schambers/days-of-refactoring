namespace LosTechies.DaysOfRefactoring.ExtractSuperclass.After
{
	public class Animal
	{
		public void EatFood()
		{
			// eat some food
		}

		public void Groom()
		{
			// perform grooming
		}
	}

	public class Dog : Animal
	{
	}
}
