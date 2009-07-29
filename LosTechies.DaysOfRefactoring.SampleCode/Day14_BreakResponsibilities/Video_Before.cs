using System.Collections.Generic;
using System.Linq;

namespace LosTechies.DaysOfRefactoring.BreakResponsibilities.Before
{
	public class Video
	{
		public void PayFee(decimal fee)
		{
		}

		public void RentVideo(Video video, Customer customer)
		{
			customer.Videos.Add(video);
		}

		public decimal CalculateBalance(Customer customer)
		{
			return customer.LateFees.Sum();
		}
	}

	public class Customer
	{
		public IList<decimal> LateFees { get; set; }
		public IList<Video> Videos { get; set; }
	}
}
