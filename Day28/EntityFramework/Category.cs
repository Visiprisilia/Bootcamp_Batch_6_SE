using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace EntityFramework
{
	public class Category
{
	public int CategoryId{get;set;} //PK
	public string CategoryName{get;set;}
	[Column (TypeName = "NText")]
	public string? Description {get;set;}
	public ICollection<Product> Products {get;set;}
	public Category()
	{
		Products = new HashSet<Product>(); //must uniq
	}
	
}

}

