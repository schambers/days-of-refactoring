using System;

namespace LosTechies.DaysOfRefactoring.EncapsulateConditional.After
{
	public class RemoteControl
	{
		private string[] Functions { get; set; }
		private string Name { get; set; }
		private int CreatedYear { get; set; }

		private bool HasExtraFunctions
		{
			get { return Functions.Length > 1 && Name == "RCA" && CreatedYear > DateTime.Now.Year - 2; }
		}

		public string PerformCoolFunction(string buttonPressed)
		{
			// Determine if we are controlling some extra function
			// that requires special conditions
			if (HasExtraFunctions)
				return "doSomething";
		}
	}
}
