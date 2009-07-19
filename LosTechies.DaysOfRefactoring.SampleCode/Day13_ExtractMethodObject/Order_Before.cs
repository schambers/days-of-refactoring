using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.ExtractMethodObject.Before
{
	public class OrderLineItem
	{
		public decimal Price { get; private set; }
	}

	public class Order
	{
		private IList<OrderLineItem> OrderLineItems { get; set; }
		private IList<decimal> Discounts { get; set; }
		private decimal Tax { get; set; }

		public decimal Calculate()
		{
			decimal subTotal = 0m;

			// Total up line items
			foreach (OrderLineItem lineItem in OrderLineItems)
			{
				subTotal += lineItem.Price;
			}

			// Subtract Discounts
			foreach (decimal discount in Discounts)
				subTotal -= discount;

			// Calculate Tax
			decimal tax = subTotal * Tax;

			// Calculate GrandTotal
			decimal grandTotal = subTotal + tax;

			return grandTotal;
		}
	}
}
