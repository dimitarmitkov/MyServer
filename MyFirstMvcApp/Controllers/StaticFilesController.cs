using System;
using System.IO;
using Server.HTTP;

namespace MyFirstMvcApp.Controllers
{
    public class StaticFilesController
    {
        HttpResponse Favicon(HttpRequest request)
        {
            var fileBytes = File.ReadAllBytes("../../../wwwroot/favicon.ico");
            var response = new HttpResponse("image/vnd.microsoft.icon", fileBytes, HttpStatusCode.OK);
            return response;
        }
    }
}
