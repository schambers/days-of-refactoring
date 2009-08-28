using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.SampleCode.CollapseHierarchy.Before
{
	public class Website
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public IEnumerable<Webpage> Pages { get; set; }
	}

	public class StudentWebsite : Website
	{
		public bool IsActive { get; set; }
	}
}
