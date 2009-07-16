namespace LosTechies.DaysOfRefactoring.PushDownField.After
{
	public abstract class Task
	{
	}

	public class BugTask : Task
	{
		private string _resolution;
	}

	public class FeatureTask : Task
	{
	}
}
