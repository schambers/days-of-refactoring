using LosTechies.DaysOfRefactoring.BreakResponsibilities.After;

namespace LosTechies.DaysOfRefactoring.SampleCode.RenameBooleanMethod.After
{
	public class BankAccount
	{
		public void CreateAccountWithChecking(Customer customer)
		{
			CreateAccount(customer, true, false);
		}

		public void CreateAccountWithCheckingAndSavings(Customer customer)
		{
			CreateAccount(customer, true, true);
		}

		private void CreateAccount(Customer customer, bool withChecking, bool withSavings)
		{
			// do work
		}
	}
}