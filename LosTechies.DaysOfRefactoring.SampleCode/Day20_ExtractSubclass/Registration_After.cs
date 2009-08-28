using System;

namespace LosTechies.DaysOfRefactoring.SampleCode.ExtractSubclass.After
{
	public class Registration
	{
		public decimal RegistrationTotal { get; set; }
		public string Description { get; set; }
		public DateTime RegistrationDate { get; set; }
	}

	public class NonRegistration : Registration
	{
		public NonRegistrationAction Action { get; set; }
		public string Notes { get; set; }
	}
}
