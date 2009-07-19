using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.ExtractMethod.After
{
	public class Receipt
	{
		private IList<decimal> Discounts { get; set; }
		private IList<decimal> ItemTotals { get; set; }

		public decimal CalculateGrandTotal()
		{
			decimal subTotal = CalculateSubTotal();

			subTotal = CalculateDiscounts(subTotal);

			subTotal = CalculateTax(subTotal);

			return subTotal;
		}

		private decimal CalculateTax(decimal subTotal)
		{
			decimal tax = subTotal * 0.065m;

			subTotal += tax;
			return subTotal;
		}

		private decimal CalculateDiscounts(decimal subTotal)
		{
			if (Discounts.Count > 0)
			{
				foreach (decimal discount in Discounts)
					subTotal -= discount;
			}
			return subTotal;
		}

		private decimal CalculateSubTotal()
		{
			decimal subTotal = 0m;
			foreach (decimal itemTotal in ItemTotals)
				subTotal += itemTotal;
			return subTotal;
		}
	}
}
