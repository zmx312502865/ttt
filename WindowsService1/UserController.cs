using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WindowsService1
{
    public class UserController : ApiController
    {
        public object GetTest(int age,string name)
        {
            return "2";
        }
        public object GetTest1()
        {
            return new { name="张三" };
        }
        [HttpGet]
        [HttpPost]
        public object GetList([FromBody]Student model)
        {
            return new List<object> { new { name = "张三" }, new { name = "李四" } };
        }



        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }

}
