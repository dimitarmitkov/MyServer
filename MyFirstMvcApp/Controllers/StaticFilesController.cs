using System.IO;
using Server.HTTP;
using Server.MvcFramework;

namespace MyFirstMvcApp.Controllers
{
    public class StaticFilesController : Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            return this.File("../../../wwwroot/favicon.ico", "image/vnd.microsoft.ico");
        }
    }
}
