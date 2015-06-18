using Demo.KendoGrid.Web.Models;

using System.Linq;
using System.Web.OData;

namespace Demo.KendoGrid.Web.Controllers
{
	public class ProductsController : ODataController
	{
		readonly ProductsContext _db = new ProductsContext();

		[EnableQuery()]
		public IQueryable<Product> Get()
		{
			var products = _db.Products.Take(300);
			return products;
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}