using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.ExtractMethodObject.After
{
	public class OrderLineItem
	{
		public decimal Price { get; private set;}
	}

	public class Order
	{
		public IEnumerable<OrderLineItem> OrderLineItems { get; private set;}
		public IEnumerable<decimal> Discounts { get; private set; }
		public decimal Tax { get; private set; }

		public decimal Calculate()
		{
			return new OrderCalculator(this).Calculate();
		}
	}

	public class OrderCalculator
	{
		private decimal SubTotal { get; set;}
		private IEnumerable<OrderLineItem> OrderLineItems { get; set; }
		private IEnumerable<decimal> Discounts { get; set; }
		private decimal Tax { get; set; }

		public OrderCalculator(Order order)
		{
			OrderLineItems = order.OrderLineItems;
			Discounts = order.Discounts;
			Tax = order.Tax;
		}

		public decimal Calculate()
		{
			CalculateSubTotal();

			SubtractDiscounts();

			CalculateTax();

			return SubTotal;
		}

		private void CalculateSubTotal()
		{
			// Total up line items
			foreach (OrderLineItem lineItem in OrderLineItems)
				SubTotal += lineItem.Price;
		}

		private void SubtractDiscounts()
		{
			// Subtract Discounts
			foreach (decimal discount in Discounts)
				SubTotal -= discount;
		}

		private void CalculateTax()
		{
			// Calculate Tax
			SubTotal += SubTotal * Tax;
		}
	}
}
