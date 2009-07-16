namespace LosTechies.DaysOfRefactoring.PushDownField.Before
{
	public abstract class Task
	{
		protected string _resolution;
	}

	public class BugTask : Task
	{
	}

	public class FeatureTask : Task
	{
	}
}
