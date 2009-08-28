using System.Collections.Generic;
using System.Linq;
using LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.After;
using Customer=LosTechies.DaysOfRefactoring.BreakResponsibilities.After.Customer;

namespace LosTechies.DaysOfRefactoring.SampleCode.ReturnASAP.After
{
	public class Order
	{
		public Customer Customer { get; private set; }

		public decimal CalculateOrder(Customer customer, IEnumerable<Product> products, decimal discounts)
		{
			if (products.Count() == 0)
				return 0;

			Customer = customer;
			decimal orderTotal = products.Sum(p => p.Price);

			if (discounts == 0)
				return orderTotal;

			orderTotal -= discounts;

			return orderTotal;
		}
	}
}
