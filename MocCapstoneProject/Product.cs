using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocCapstoneProject {
	class Product {
		public string Name { get; set; }
		public string ProductId { get; set; }
		public Vendor Vendor { get; set; }
		public string Unit { get; set; }
		public double Price { get; set; }
	}
}
