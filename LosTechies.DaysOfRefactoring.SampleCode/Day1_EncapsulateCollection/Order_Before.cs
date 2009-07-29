using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.EncapsulateCollection.Before
{
	public class Order
	{
		private List<OrderLine> _orderLines;
		private double _orderTotal;

		public IList<OrderLine> OrderLines
		{
			get { return _orderLines; }
		}

		public void AddOrderLine(OrderLine orderLine)
		{
			_orderTotal += orderLine.Total;
			_orderLines.Add(orderLine);
		}

		public void RemoveOrderLine(OrderLine orderLine)
		{
			orderLine = _orderLines.Find(o => o == orderLine);

			if (orderLine == null)
				return;

			_orderTotal -= orderLine.Total;
			_orderLines.Remove(orderLine);
		}
	}

	public class OrderLine
	{
		public double Total { get; private set; }
	}
}
