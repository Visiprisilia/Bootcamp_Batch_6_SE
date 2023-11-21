namespace Database;

public class Category
{
	public Guid CategoryId { get; set; } //pk GUID
	public string CategoryName { get; set; } = null!; //required
	public string? Description { get; set; }//optional
	public ICollection<Product> Products {get; set;}
	public Category()
	{
		Products = new HashSet<Product>();
	}
	
}
