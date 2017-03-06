using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controller
{
    public class AccountController : ApiController
    {
        public string GetTest()
        {
            return "2";
        }
        public string GetTest1()
        {
            return "1";
        }
    }
}