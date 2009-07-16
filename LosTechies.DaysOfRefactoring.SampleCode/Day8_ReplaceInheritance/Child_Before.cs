namespace LosTechies.DaysOfRefactoring.ReplaceInheritance.Before
{
	public class Sanitation
	{
		public string WashHands()
		{
			return "Cleaned!";
		}
	}

	public class Child : Sanitation
	{
	}
}
