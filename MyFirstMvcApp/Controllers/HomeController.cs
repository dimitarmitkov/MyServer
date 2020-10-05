using System.Linq;
using System.Text;
using Server.HTTP;
using Server.MvcFramework;

namespace MyFirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {

            return this.View();
        }
    }
}
