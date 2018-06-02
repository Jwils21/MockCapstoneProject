using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocCapstoneProject {
	class Vendor {
		public string VendorId { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string Email { get; set; }


		public List<Product> Products = new List<Product>();
	}
}
