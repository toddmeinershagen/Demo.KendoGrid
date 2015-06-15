using System.Data.Entity;

namespace Demo.KendoGrid.Web.Models
{
	public class ProductsContext : DbContext
	{
		public ProductsContext()
			: base("name=ProductsContext")
		{
		}
		public DbSet<Product> Products { get; set; }
	}
}