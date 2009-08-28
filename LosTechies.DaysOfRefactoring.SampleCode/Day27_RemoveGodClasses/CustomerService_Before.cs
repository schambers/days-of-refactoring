using System.Collections.Generic;
using LosTechies.DaysOfRefactoring.EncapsulateCollection.After;
using LosTechies.DaysOfRefactoring.SampleCode.BreakMethod.After;
using Customer=LosTechies.DaysOfRefactoring.BreakResponsibilities.After.Customer;

namespace LosTechies.DaysOfRefactoring.SampleCode.RemoveGodClasses.Before
{
	public class CustomerService
	{
		public decimal CalculateOrderDiscount(IEnumerable<Product> products, Customer customer)
		{
			// do work
		}

		public bool CustomerIsValid(Customer customer, Order order)
		{
			// do work
		}

		public IEnumerable<string> GatherOrderErrors(IEnumerable<Product> products, Customer customer)
		{
			// do work
		}

		public void Register(Customer customer)
		{
			// do work
		}

		public void ForgotPassword(Customer customer)
		{
			// do work
		}
	}
}
