using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.SampleCode.ParameterObject.Before
{
	public class Registration
	{
		public void Create(decimal amount, Student student, IEnumerable<Course> courses, decimal credits)
		{
			// do work
		}
	}
}
