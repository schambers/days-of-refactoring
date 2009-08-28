using System;
using System.Collections.Generic;
using System.Linq;

namespace LosTechies.DaysOfRefactoring.SwitchToStrategy.After_WithIoC
{
	public interface IShippingInfo
	{
		decimal CalculateShippingAmount(State state);
	}

	public class ClientCode
	{
		[Inject]
		public IShippingInfo ShippingInfo { get; set; }

		public decimal CalculateShipping()
		{
			return ShippingInfo.CalculateShippingAmount(State.Alaska);
		}
	}

	public enum State
	{
		Alaska,
		NewYork,
		Florida
	}

	public class ShippingInfo : IShippingInfo
	{
		private IDictionary<State, IShippingCalculation> ShippingCalculations { get; set; }

		public ShippingInfo(IEnumerable<IShippingCalculation> shippingCalculations)
		{
			ShippingCalculations = shippingCalculations.ToDictionary(calc => calc.State);
		}

		public decimal CalculateShippingAmount(State shipToState)
		{
			return ShippingCalculations[shipToState].Calculate();
		}
	}

	public interface IShippingCalculation
	{
		State State { get; }
		decimal Calculate();
	}

	public class AlaskShippingCalculation : IShippingCalculation
	{
		public State State { get { return State.Alaska; } }

		public decimal Calculate()
		{
			return 15m;
		}
	}

	public class NewYorkShippingCalculation : IShippingCalculation
	{
		public State State { get { return State.NewYork; } }

		public decimal Calculate()
		{
			return 10m;
		}
	}

	public class FloridaShippingCalculation : IShippingCalculation
	{
		public State State { get { return State.Florida; } }

		public decimal Calculate()
		{
			return 3m;
		}
	}
}

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
