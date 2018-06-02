using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocCapstoneProject {
	class Program {
		static void Main(string[] args) {
			User Jonathan = new User() {
				email = "Jon@email.com",
				IsReviewer = true,
				Name = "Jonathan",
				Username = "jwils"
			};
			User Bob = new User() {
				Name = "Bob",
				email = "Bob@email.com",
				Username = "bobby"
			};
			Vendor Amazon = new Vendor() {
				Name = "Amazon",
				City = "Seattle",
				Email = "Orders@amazon.com",
				VendorId = "AMZN"
			};
			Vendor Costco = new Vendor() {
				Name = "Amazon",
				City = "Silverton",
				Email = "Orders@Costco.com",
				VendorId = "Cstco"
			};
			Product Echo = new Product() {
				Name = "Echo",
				Price = 99.99,
				ProductId = "AmznEcho",
				Unit = "Each",
				Vendor = Amazon
			};
			Product Vizio4KMonitor = new Product() {
				Name = "Vizio 4K TV",
				Price = 799.99,
				ProductId = "VizioTv",
				Unit = "Each",
				Vendor = Costco
			};
			Product Chair = new Product() {
				Name = "Office Chair",
				Vendor = Amazon,
				Unit = "Each",
				Price = 149.99,
				ProductId = "AmznChair"
			};
			//Jonathan.NewPurchaseRequest(Jonathan, Amazon, Chair, DateTime.Today, "Chair for office", 1);
			Jonathan.PurchRequestforAllUsers(Amazon, Echo, DateTime.Today, "Everyone needs a chair", 1);
		}
			
	}
}
