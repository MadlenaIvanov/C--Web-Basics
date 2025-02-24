﻿using BasicWebServer.Demo.Controllers;
using BasicWebServer.Server;
using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using BasicWebServer.Server.Responses;
using BasicWebServer.Server.Routing;
using System.Text;
using System.Web;

namespace BasicWebServer.Demo
{
    public class Startup
    {

        

        public static async Task Main()
        {

            await new HttpServer(routes => routes
            .MapControllers())
               .Start();
        }
    }
}