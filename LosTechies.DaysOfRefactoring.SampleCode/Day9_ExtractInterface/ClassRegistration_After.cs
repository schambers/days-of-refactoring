namespace LosTechies.DaysOfRefactoring.ExtractInterface.After
{
	public interface IClassRegistration
	{
		void Create();
		decimal Total { get; }
	}

	public class ClassRegistration : IClassRegistration
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
		public decimal ProcessRegistration(IClassRegistration registration)
		{
			registration.Create();
			return registration.Total;
		}
	}
}
