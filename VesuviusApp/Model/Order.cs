using System;
namespace VesuviusApp.Model
{
	public class Order
	{
		public int id { get; set; }

		public int price_total { get; set; }

		public DateTime order_date { get; set; }

		public int customer_count { get; set; }

		public string order_state { get; set; }

		public int employee_id { get; set; }

		public int customer_id { get; set; }
	}
}

