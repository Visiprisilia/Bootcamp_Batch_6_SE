using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EntityFramework
{
public class Product
{
	public int ProductId {get;set;}//PK
	[Required] //not null 
	[StringLength(40)] //max 40 
	public string ProductName {get; set;} =null!;
	
	[Column("UnitPrice", TypeName = "money")]
	public decimal? Cost {get; set;} //nama yang di database diganti menjadi cost
	
	[Column("UnitsInStock")]
	public short? Stock {get; set;}
	public bool Discontinued {get; set;}
	public int CategoryId {get; set;}//FK dari Category 
	public virtual Category Category {get; set;} = null!; 	
	  
	
}
}