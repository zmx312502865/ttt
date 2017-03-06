using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Controller;

namespace ConsoleApplication1
{
    public class UserController : ApiController
    {
        [HttpGet]
        public string GetTest()
        {
            return "2";
        }
        public string GetTest1()
        {
            return "1";
        }
    }
    //public class DefaultController : ApiController
    //{
    //    [HttpGet]
    //    public string GetTest()
    //    {
    //        return "2";
    //    }
    //    public string GetTest1()
    //    {
    //        return "1";
    //    }
    //}
}
