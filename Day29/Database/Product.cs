namespace Database;

public class Product
{
	public Guid ProductId { get; set; } //pk guid
	public string ProductName { get; set; } =null!; //required
	public string? Description { get; set; }
	public Category Category {get; set;} = null!;
	public Guid CategoryId {get; set;}
	
}
