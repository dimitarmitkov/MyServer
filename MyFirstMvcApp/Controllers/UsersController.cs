using System;
using System.Text;
using Server.HTTP;

namespace MyFirstMvcApp.Controllers
{
    public class UsersController
    {
        HttpResponse Login(HttpRequest request)
        {
            var responseHtml = "<h3>Login</h3>";
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);

            return response;
        }

        HttpResponse Register(HttpRequest request)
        {
            var responseHtml = "<h3>Register</h3>";
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);

            return response;
        }
    }
}
