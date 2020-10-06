using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Server.HTTP;

namespace Server.MvcFramework
{
    public static class Host
    {

        public static async Task CreateHostAsync(IMvcApplication application, int port)
        {
            List<Route> routeTable = new List<Route>();
            application.ConfigureServices();
            application.Configure(routeTable);


            IHttpServer server = new HttpServer(routeTable);



            await server.StartAsync(port);
        }

        //public static async Task CreateHostAsync(IMvcApplication application, int port = 63342)
        //{
        //    // TODO: {controller}/{action}/{id}
        //    List<Route> routeTable = new List<Route>();
        //    application.ConfigureServices();
        //    application.Configure(routeTable);

        //    IHttpServer server = new HttpServer(routeTable);

        //    // Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://localhost/");
        //    await server.StartAsync(port);
        //}

    }
}
