using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Contracts;

namespace LosTechies.DaysOfRefactoring.SampleCode.DesignByContract.After
{
	public class CashRegister
	{
		public decimal TotalOrder(IEnumerable<Product> products, Customer customer)
		{
			if (customer == null)
				throw new ArgumentNullException("customer", "Customer cannot be null");
			if (products.Count() == 0)
				throw new ArgumentException("Must have at least one product to total", "products");

			decimal orderTotal = products.Sum(product => product.Price);

			customer.Balance += orderTotal;

			if (orderTotal == 0)
				throw new ArgumentOutOfRangeException("orderTotal", "Order Total should not be zero");

			return orderTotal;
		}
	}
}
