using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            var url = "http://localhost:8080/";
            var startOpts = new StartOptions(url)
            {
            };
            using (WebApp.Start<Startup>(startOpts))
            {
                Console.WriteLine("Server run at " + url + " , press Enter to exit.");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }



}
