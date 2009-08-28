using System.Collections.Generic;
using System.Linq;

namespace LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.Before
{
	public class CashRegister
	{
		public CashRegister()
		{
			Tax = 0.06m;
		}

		private decimal Tax { get; set; }

		public void AcceptPayment(Customer customer, IEnumerable<Product> products, decimal payment)
		{
			decimal subTotal = 0m;
			foreach (Product product in products)
			{
				subTotal += product.Price;
			}

			foreach(Product product in products)
			{
				subTotal -= product.AvailableDiscounts;
			}

			decimal grandTotal = subTotal * Tax;

			customer.DeductFromAccountBalance(grandTotal);
		}
	}

	public class Customer
	{
		public void DeductFromAccountBalance(decimal amount)
		{
			// deduct from balance
		}
	}

	public class Product
	{
		public decimal Price { get; set; }
		public decimal AvailableDiscounts { get; set; }
	}
}
