using System;

namespace Demo.Models {
	public class Product {
		public Guid Id { get; set; }
		public string Name { get; set; }
		public ProductType Type { get; set; }
	}

	public enum ProductType {
		Phone,
		Laptop
	}
}
