using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.After;

namespace LosTechies.DaysOfRefactoring.SampleCode.ReplaceWithPolymorphism.Before
{
	public abstract class Customer
	{
	}

	public class Employee : Customer
	{
	}

	public class NonEmployee : Customer
	{
	}

	public class OrderProcessor
	{
		public decimal ProcessOrder(Customer customer, IEnumerable<Product> products)
		{
			// do some processing of order
			decimal orderTotal = products.Sum(p => p.Price);

			Type customerType = customer.GetType();
			if (customerType == typeof(Employee))
			{
				orderTotal -= orderTotal * 0.15m;
			}
			else if (customerType == typeof(NonEmployee))
			{
				orderTotal -= orderTotal * 0.05m;
			}

			return orderTotal;
		}
	}
}
