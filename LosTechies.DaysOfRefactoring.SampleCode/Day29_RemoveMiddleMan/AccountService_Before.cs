using LosTechies.DaysOfRefactoring.PullUpField.After;

namespace LosTechies.DaysOfRefactoring.SampleCode.RemoveMiddleMan.Before
{
	public class Consumer
	{
		public AccountManager AccountManager { get; set; }

		public Consumer(AccountManager accountManager)
		{
			AccountManager = accountManager;
		}

		public void Get(int id)
		{
			Account account = AccountManager.GetAccount(id);
		}
	}

	public class AccountManager
	{
		public AccountDataProvider DataProvider { get; set; }

		public AccountManager(AccountDataProvider dataProvider)
		{
			DataProvider = dataProvider;
		}

		public Account GetAccount(int id)
		{
			return DataProvider.GetAccount(id);
		}
	}

	public class AccountDataProvider
	{
		public Account GetAccount(int id)
		{
			// get account
		}
	}
}
