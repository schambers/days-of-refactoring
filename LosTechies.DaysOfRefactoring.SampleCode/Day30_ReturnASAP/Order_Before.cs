using System.Collections.Generic;
using System.Linq;
using LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.After;
using Customer=LosTechies.DaysOfRefactoring.BreakResponsibilities.After.Customer;

namespace LosTechies.DaysOfRefactoring.SampleCode.ReturnASAP.Before
{
	public class Order
	{
		public Customer Customer { get; private set; }

		public decimal CalculateOrder(Customer customer, IEnumerable<Product> products, decimal discounts)
		{
			Customer = customer;
			decimal orderTotal = 0m;

			if (products.Count() > 0)
			{
				orderTotal = products.Sum(p => p.Price);
				if (discounts > 0)
				{
					orderTotal -= discounts;
				}
			}

			return orderTotal;
		}
	}
}
