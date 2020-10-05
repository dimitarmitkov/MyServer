using System;
using System.Net;
using System.Threading.Tasks;

namespace Server.HTTP
{
    public interface IHttpServer
    {
        Task StartAsync(int port);
    }
}
