﻿using Exceptionless;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Controller;

namespace WindowsService1
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            

            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            appBuilder.UseWebApi(config);
            Exceptionless.ExceptionlessClient.Default.RegisterWebApi(config);
            //appBuilder.Run(HandleRequest);
        }

        //static Task HandleRequest(IOwinContext context)
        //{
        //    context.Response.ContentType = "text/plain";
        //    return context.Response.WriteAsync("Hello, world!");
        //}
    }
}
