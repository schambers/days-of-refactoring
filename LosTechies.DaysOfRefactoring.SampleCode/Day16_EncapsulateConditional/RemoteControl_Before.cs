using System;

namespace LosTechies.DaysOfRefactoring.EncapsulateConditional.Before
{
	public class RemoteControl
	{
		private string[] Functions { get; set; }
		private string Name { get; set; }
		private int CreatedYear { get; set; }

		public string PerformCoolFunction(string buttonPressed)
		{
			// Determine if we are controlling some extra function
			// that requires special conditions
			if (Functions.Length > 1 && Name == "RCA" && CreatedYear > DateTime.Now.Year - 2)
				return "doSomething";
		}
	}
}
