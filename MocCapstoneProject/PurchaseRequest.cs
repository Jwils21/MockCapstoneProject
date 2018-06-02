using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocCapstoneProject {
	class PurchaseRequest {
		public string Description { get; set; }
		public string Status { get; set; }
		public User User { get; set; }
		public Vendor Vendor { get; set; }
		public Product Product { get; set; }
		public DateTime DateNeeded { get; set; }
		public int Quantity { get; set; }
	}
}
