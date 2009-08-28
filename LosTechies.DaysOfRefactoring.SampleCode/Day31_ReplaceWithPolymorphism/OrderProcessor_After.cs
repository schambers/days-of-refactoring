using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.After;

namespace LosTechies.DaysOfRefactoring.SampleCode.ReplaceWithPolymorphism.After
{
	public abstract class Customer
	{
		public abstract decimal DiscountPercentage { get; }
	}

	public class Employee : Customer
	{
		public override decimal DiscountPercentage
		{
			get { return 0.15m; }
		}
	}

	public class NonEmployee : Customer
	{
		public override decimal DiscountPercentage
		{
			get { return 0.05m; }
		}
	}

	public class OrderProcessor
	{
		public decimal ProcessOrder(Customer customer, IEnumerable<Product> products)
		{
			// do some processing of order
			decimal orderTotal = products.Sum(p => p.Price);

			orderTotal -= orderTotal * customer.DiscountPercentage;

			return orderTotal;
		}
	}
}
