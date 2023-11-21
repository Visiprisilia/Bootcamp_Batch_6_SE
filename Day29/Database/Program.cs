using Database;

class Program
{
	static async Task Main()
	{
		using (Northwind db = new Northwind())
		{
			Console.WriteLine($"Name: {db.Database}");
			Console.WriteLine($"Database: {db.Database.ProviderName}");
			Console.WriteLine($"Database connection: {db.Database.CanConnect()}");
			IQueryable<Category> categories = db.Categories;
			foreach (Category c in categories)
			{
				Console.WriteLine(c.CategoryName);
				foreach(Product p in c.Products) 
				{
					Console.WriteLine($"\t {p.ProductName}");
				}
			}
			var products = db.Products;
			foreach(Product p in products) 
				{
					Console.WriteLine($"\t {p.ProductName}");
				}

			}
	// 	using (Northwind db = new Northwind())
	// 	{
			// Guid catguid = db.Categories
			// 				.FirstOrDefault(c => c.CategoryName == "Kendaraan")
			// 				.CategoryId;
	// 		Product newProduct = new Product()
	// 		{
	// 			ProductId = Guid.NewGuid(),
	// 			ProductName = "Kijang",
	// 			Description = "Ini Kijang",
	// 			CategoryId = Guid.Parse("2fc94449-99cb-481e-826f-633af1e38981")
	// 		};
	// 		await db.Products.AddAsync(newProduct);
	// 		await db.SaveChangesAsync();
	// }
	// using (Northwind db = new Northwind())
	// 	{
		
		// Guid catguid = db.Categories
			// 				.FirstOrDefault(c => c.CategoryName == "Kendaraan")
			// 				.CategoryId;
	// 		Category newCategory = new Category()
	// 		{
	// 			CategoryId = Guid.NewGuid(),
	// 			CategoryName = "Kendaraan",
	// 			Description = "Ini Kendaraan",
				// CategoryId = Guid.Parse("2fc94449-99cb-481e-826f-633af1e38981")
	// 		};
	// 		await db.Categories.AddAsync(newCategory);
	// 		await db.SaveChangesAsync();
	// 	}
}
}