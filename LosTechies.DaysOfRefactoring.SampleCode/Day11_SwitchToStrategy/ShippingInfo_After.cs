using System.Collections.Generic;

namespace LosTechies.DaysOfRefactoring.SwitchToStrategy.After
{
	public class ClientCode
	{
		public decimal CalculateShipping()
		{
			ShippingInfo shippingInfo = new ShippingInfo();
			return shippingInfo.CalculateShippingAmount(State.Alaska);
		}
	}

	public enum State
	{
		Alaska,
		NewYork,
		Florida
	}

	public class ShippingInfo
	{
		private IDictionary<State, IShippingCalculation> ShippingCalculations { get; set; }

		public ShippingInfo()
		{
			ShippingCalculations = new Dictionary<State, IShippingCalculation>
			{
				{ State.Alaska, new AlaskShippingCalculation() },
				{ State.NewYork, new NewYorkShippingCalculation() },
				{ State.Florida, new FloridaShippingCalculation() }
			};
		}

		public decimal CalculateShippingAmount(State shipToState)
		{
			return ShippingCalculations[shipToState].Calculate();
		}
	}

	public interface IShippingCalculation
	{
		decimal Calculate();
	}

	public class AlaskShippingCalculation : IShippingCalculation
	{
		public decimal Calculate()
		{
			return 15m;
		}
	}

	public class NewYorkShippingCalculation : IShippingCalculation
	{
		public decimal Calculate()
		{
			return 10m;
		}
	}

	public class FloridaShippingCalculation : IShippingCalculation
	{
		public decimal Calculate()
		{
			return 3m;
		}
	}
}
