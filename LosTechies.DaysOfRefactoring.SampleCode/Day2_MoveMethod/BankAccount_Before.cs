namespace LosTechies.DaysOfRefactoring.MoveMethod.Before
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

		public double CalculateInterestRate()
		{
			if (CreditScore > 800)
				return 0.02;

			if (AccountAge > 10)
				return 0.03;

			return 0.05;
		}
	}

	public class AccountInterest
	{
		public BankAccount Account { get; private set; }

		public AccountInterest(BankAccount account)
		{
			Account = account;
		}

		public double InterestRate
		{
			get { return Account.CalculateInterestRate(); }
		}

		public bool IntroductoryRate
		{
			get { return Account.CalculateInterestRate() < 0.05; }
		}
	}
}

namespace LosTechies.DaysOfRefactoring.MoveMethod.After
{
	public class AccountInterest
	{
		public BankAccount Account { get; private set; }

		public AccountInterest(BankAccount account)
		{
			Account = account;
		}

		public double InterestRate
		{
			get { return CalculateInterestRate(); }
		}

		public bool IntroductoryRate
		{
			get { return CalculateInterestRate() < 0.05; }
		}

		public double CalculateInterestRate()
		{
			if (Account.CreditScore > 800)
				return 0.02;

			if (Account.AccountAge > 10)
				return 0.03;

			return 0.05;
		}
	}
}