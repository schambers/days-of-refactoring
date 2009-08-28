using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.SampleCode.ParameterObject.After
{
	public class RegistrationContext
	{
		public decimal Amount { get; set; }
		public Student Student { get; set; }
		public IEnumerable<Course> Courses { get; set; }
		public decimal Credits { get; set; }
	}

	public class Registration
	{
		public void Create(RegistrationContext registrationContext)
		{
			// do work
		}
	}
}
