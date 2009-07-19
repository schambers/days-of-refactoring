using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.ExtractMethod.Before
{
	public class Receipt
	{
		private IList<decimal> Discounts { get; set; }
		private IList<decimal> ItemTotals { get; set; }

		public decimal CalculateGrandTotal()
		{
			decimal subTotal = 0m;
			foreach (decimal itemTotal in ItemTotals)
				subTotal += itemTotal;

			if (Discounts.Count > 0)
			{
				foreach (decimal discount in Discounts)
					subTotal -= discount;
			}

			decimal tax = subTotal * 0.065m;

			subTotal += tax;

			return subTotal;
		}
	}
}
