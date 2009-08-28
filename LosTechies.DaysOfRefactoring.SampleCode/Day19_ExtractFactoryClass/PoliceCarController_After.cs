namespace LosTechies.DaysOfRefactoring.ExtractServiceClass.After
{
	public interface IPoliceCarFactory
	{
		PoliceCar Create(int mileage, bool serviceRequired);
	}

	public class PoliceCarFactory : IPoliceCarFactory
	{
		public PoliceCar Create(int mileage, bool serviceRequired)
		{
			PoliceCar policeCar = new PoliceCar();
			policeCar.ReadForService = serviceRequired;
			policeCar.Mileage = mileage;
			return policeCar;
		}
	}

	public class PoliceCarController
	{
		public IPoliceCarFactory PoliceCarFactory { get; set; }

		public PoliceCarController(IPoliceCarFactory policeCarFactory)
		{
			PoliceCarFactory = policeCarFactory;
		}

		public PoliceCar New(int mileage, bool serviceRequired)
		{
			return PoliceCarFactory.Create(mileage, serviceRequired);
		}
	}
}
