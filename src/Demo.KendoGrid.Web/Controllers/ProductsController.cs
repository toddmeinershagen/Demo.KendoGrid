using System.Web.Http;

using Demo.KendoGrid.Web.Models;

using System.Linq;
using System.Web.OData;

namespace Demo.KendoGrid.Web.Controllers
{
	public class ProductsController : ODataController
	{
		readonly ProductsContext _db = new ProductsContext();

		private bool ProductExists(int key)
		{
			return _db.Products.Any(p => p.Id == key);
		}

		[EnableQuery]
		public IQueryable<Product> Get()
		{
			return _db.Products;
		}

		[EnableQuery]
		public SingleResult<Product> Get([FromODataUri] int key)
		{
			IQueryable<Product> result = _db.Products.Where(p => p.Id == key);
			return SingleResult.Create(result);
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}