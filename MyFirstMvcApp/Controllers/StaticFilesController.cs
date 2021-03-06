﻿using System;
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

        internal HttpResponse BootstrapCss(HttpRequest arg)
        {
            return this.File("../../../wwwroot/css/bootstrap.min.css", "text/css");

        }

        internal HttpResponse CustomCss(HttpRequest arg)
        {
            return this.File("../../../wwwroot/css/custom.css", "text/css");

        }

        internal HttpResponse CustomJs(HttpRequest arg)
        {
            return this.File("../../../wwwroot/js/custom.js", "text/javascript");

        }

        internal HttpResponse BootstrapJs(HttpRequest arg)
        {
            return this.File("../../../wwwroot/js/bootstrap.bundle.min.js", "text/javascript");

        }
    }
}
