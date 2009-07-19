namespace LosTechies.DaysOfRefactoring.ExtractInterface.Before
{
	public class ClassRegistration
	{
		public void Create()
		{
			// create registration code
		}

		public void Transfer()
		{
			// class transfer code
		}

		public decimal Total { get; private set; }
	}

	public class RegistrationProcessor
	{
		public decimal ProcessRegistration(ClassRegistration registration)
		{
			registration.Create();
			return registration.Total;
		}
	}
}
