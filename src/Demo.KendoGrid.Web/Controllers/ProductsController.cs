using System.Web.Http;

using Demo.KendoGrid.Web.Models;

using System.Linq;
using System.Web.OData;

namespace Demo.KendoGrid.Web.Controllers
{
	public class ProductsController : ODataController
	{
		readonly ProductsContext _db = new ProductsContext();

		[EnableQuery]
		public IQueryable<Product> Get()
		{
			return _db.Products;
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}