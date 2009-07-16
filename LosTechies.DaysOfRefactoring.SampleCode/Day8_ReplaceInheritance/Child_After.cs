namespace LosTechies.DaysOfRefactoring.ReplaceInheritance.After
{
	public class Sanitation
	{
		public string WashHands()
		{
			return "Cleaned!";
		}
	}

	public class Child
	{
		private Sanitation Sanitation { get; set; }

		public Child()
		{
			Sanitation = new Sanitation();
		}

		public string WashHands()
		{
			return Sanitation.WashHands();
		}
	}
}
