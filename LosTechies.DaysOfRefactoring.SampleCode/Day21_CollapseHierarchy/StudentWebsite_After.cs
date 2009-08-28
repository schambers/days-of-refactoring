using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.SampleCode.CollapseHierarchy.After
{
	public class Website
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public IEnumerable<Webpage> Pages { get; set; }
		public bool IsActive { get; set; }
	}
}
