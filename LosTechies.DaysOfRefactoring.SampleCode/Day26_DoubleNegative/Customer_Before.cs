using System.Collections.Generic;
using LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.After;

namespace LosTechies.DaysOfRefactoring.SampleCode.DoubleNegative.Before
{
	public class Order
	{
		public void Checkout(IEnumerable<Product> products, Customer customer)
		{
			if (!customer.IsNotFlagged)
			{
				// the customer account is flagged
				// log some errors and return
				return;
			}

			// normal order processing
		}
	}

	public class Customer
	{
		public decimal Balance { get; private set; }

		public bool IsNotFlagged
		{
			get { return Balance < 30m; }
		}
	}
}
