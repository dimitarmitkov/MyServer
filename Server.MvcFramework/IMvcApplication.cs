using System;
using System.Collections.Generic;
using Server.HTTP;

namespace Server.MvcFramework
{
    public interface IMvcApplication
    {
        void ConfigureServices();

        void Configure(List<Route> routeTable);
    }
}
