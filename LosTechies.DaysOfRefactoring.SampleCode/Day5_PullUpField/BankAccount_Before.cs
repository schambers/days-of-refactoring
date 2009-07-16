using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LosTechies.DaysOfRefactoring.PullUpField.Before
{
	public abstract class Account
	{
	}

	public class CheckingAccount : Account
	{
		private decimal _minimumCheckingBalance = 5m;
	}

	public class SavingsAccount : Account
	{
		private decimal _minimumSavingsBalance = 5m;
	}
}
