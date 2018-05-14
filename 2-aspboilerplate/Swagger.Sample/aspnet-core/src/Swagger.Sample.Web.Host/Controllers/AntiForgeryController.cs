using Microsoft.AspNetCore.Antiforgery;
using Swagger.Sample.Controllers;

namespace Swagger.Sample.Web.Host.Controllers
{
    public class AntiForgeryController : SampleControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
