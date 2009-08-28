using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LosTechies.DaysOfRefactoring.SampleCode.Day25_DesignByContract
{
	public class CashRegister
	{
		public decimal TotalOrder(IEnumerable<Product> products, Customer customer)
		{
			decimal orderTotal = products.Sum(product => product.Price);

			customer.Balance += orderTotal;

			return orderTotal;
		}
	}
}
