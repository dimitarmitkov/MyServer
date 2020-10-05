using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMvcApp.Controllers;
using Server.HTTP;

namespace MyFirstMvcApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHttpServer server = new HttpServer();

            server.AddRoute("/", new HomeController().Index);

            server.AddRoute("/favicon.ico", Favicon);

            server.AddRoute("/about", About);

            server.AddRoute("/users/login", Login);

            server.AddRoute("/users/register", Register);

            await server.StartAsync(63342);

        }







        static HttpResponse Favicon(HttpRequest request)
        {
            var fileBytes = File.ReadAllBytes("../../../wwwroot/favicon.ico");
            var response = new HttpResponse("image/vnd.microsoft.icon", fileBytes, HttpStatusCode.OK);
            return response;
        }
    }
}
