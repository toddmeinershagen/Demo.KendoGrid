using System.Web.Http;

using Demo.KendoGrid.Web.Models;

using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace Demo.KendoGrid.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

			ODataModelBuilder builder = new ODataConventionModelBuilder();
			builder.EntitySet<Product>("Products");
			config.MapODataServiceRoute(
				routeName: "ODataRoute",
				routePrefix: "odata",
				model: builder.GetEdmModel());
        }
    }
}
