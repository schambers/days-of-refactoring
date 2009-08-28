namespace LosTechies.DaysOfRefactoring.ExtractServiceClass.Before
{
	public class PoliceCarController
	{
		public PoliceCar New(int mileage, bool serviceRequired)
		{
			PoliceCar policeCar = new PoliceCar();
			policeCar.ServiceRequired = serviceRequired;
			policeCar.Mileage = mileage;

			return policeCar;
		}
	}
}
