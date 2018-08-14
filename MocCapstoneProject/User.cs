using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocCapstoneProject {
	
	class User {
		public string Name { get; set; }
		public string Username { get; set; }
		public bool IsReviewer { get; set; }
		public string email { get; set; }
		public List<PurchaseRequest> PurchaseRequests = new List<PurchaseRequest>();S

		public PurchaseRequest NewPurchaseRequest (User user, Vendor vendor, Product product, DateTime dateNeeded, string description , int quantity,String status = "New" ) {
			PurchaseRequest PurReq = new PurchaseRequest() {
				Vendor = vendor,
				DateNeeded = dateNeeded,
				Description = description,
				Status = status,
				User = user,
				Quantity = quantity,
			};
			return PurReq;
		}

		public List<User> Users = new List<User>();

		public void PurchRequestforAllUsers( Vendor vendor, Product product, DateTime dateNeeded, string description, int quantity, String status = "New") {
			foreach (User user in Users) {
				PurchaseRequest PurchReq = new PurchaseRequest() {
					User = user,
					Vendor = vendor,
					DateNeeded = dateNeeded,
					Description = description,
					Quantity = quantity,
					Product = product,
					Status = status,
				};
			}
		}
	}
}
