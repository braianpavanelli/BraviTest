using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

namespace BraviBraian.MVC.Controllers
{
    public class BaseController : Controller
    {
        public string UriApi = ConfigurationManager.AppSettings["ApiUri"];
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ViewBag.UriApi = UriApi;
        }
    }
}