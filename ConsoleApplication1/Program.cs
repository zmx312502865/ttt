using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controller;
using WindowsService1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly.Load("WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
            //var url = "http://localhost:8081/";
            //var startOpts = new StartOptions(url)
            //{
            //};
            //using (WebApp.Start<Startup>(startOpts))
            //{
            //    Console.WriteLine("Server run at " + url + " , press Enter to exit.");
            //    Console.ReadLine();
            //}


            using (WebClient client = new WebClient())
            {

                var s = client.DownloadString("http://127.0.0.1:8500/v1/agent/checks");



            }

            Console.ReadKey();
        }
    }



}
