using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LosTechies.DaysOfRefactoring.PullUpField.After
{
	public abstract class Account
	{
		protected decimal _minimumBalance = 5m;
	}

	public class CheckingAccount : Account
	{
	}

	public class SavingsAccount : Account
	{
	}
}
