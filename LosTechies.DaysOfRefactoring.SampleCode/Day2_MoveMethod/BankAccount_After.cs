namespace LosTechies.DaysOfRefactoring.MoveMethod.After
{
	public class BankAccount
	{
		public BankAccount(int accountAge, int creditScore, AccountInterest accountInterest)
		{
			AccountAge = accountAge;
			CreditScore = creditScore;
			AccountInterest = accountInterest;
		}

		public int AccountAge { get; private set; }
		public int CreditScore { get; private set; }
		public AccountInterest AccountInterest { get; private set; }
	}
}