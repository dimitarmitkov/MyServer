﻿using Server.HTTP;
using Server.MvcFramework;

namespace MyFirstMvcApp.Controllers
{
    public class CardsController : Controller
    {
        public HttpResponse Add(HttpRequest request)
        {

            return this.View();
            //return this.View("../../../Views/Cards/Add.html");
        }

        public HttpResponse All(HttpRequest request)
        {

            return this.View();
            //return this.View("../../../Views/Cards/All.html");
        }

        public HttpResponse Collection(HttpRequest request)
        {

            return this.View();
            //return this.View("../../../Views/Cards/Collection.html");
        }

    }
}
