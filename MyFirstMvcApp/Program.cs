using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MyFirstMvcApp.Controllers;
using Server.HTTP;
using Server.MvcFramework;

namespace MyFirstMvcApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Host.CreateHostAsync(new Startup(), 63342);
        }
    }
}
