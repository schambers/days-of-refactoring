using LosTechies.DaysOfRefactoring.BreakResponsibilities.After;

namespace LosTechies.DaysOfRefactoring.SampleCode.RenameBooleanMethod.Before
{
	public class BankAccount
	{
		public void CreateAccount(Customer customer, bool withChecking, bool withSavings, bool withStocks)
		{
			// do work
		}
	}
}