
using Microsoft.Owin.Hosting;
using System;
using System.ServiceProcess;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
            }
            var url = "http://localhost:8080/";
            //var startOpts = new StartOptions(url)
            //{

            //};
            WebApp.Start<Startup>(url);


        }

        protected override void OnStop()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Stop.");
            }
        }

        //private HttpSelfHostServer _server;
        //private readonly HttpSelfHostConfiguration _config;
        //public const string ServiceAddress = "http://localhost:8088";
        //public Service1()
        //{
        //    InitializeComponent();

        //    _config = new HttpSelfHostConfiguration(ServiceAddress);
        //    _config.Routes.MapHttpRoute("DefaultApi",
        //        "api/{controller}/{action}/{id}",
        //        new { id = RouteParameter.Optional });
        //}

        //protected override void OnStart(string[] args)
        //{
        //    _server = new HttpSelfHostServer(_config);
        //    _server.OpenAsync();
        //}

        //protected override void OnStop()
        //{
        //    _server.CloseAsync().Wait();
        //    _server.Dispose();
        //}

    }
}
