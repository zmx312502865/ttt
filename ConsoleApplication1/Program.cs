using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public class Student
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            int k = 2;
            Expression<Func<Student, bool>> ss = (model) => model.Age > 1;
            Expression<Func<Student, bool>> ss1 = (model) => model.Name == "张三";
            Func<int, int> s1 = (p) => { return p; };

            IList<Student> list = new List<Student>()
            {
                new Student() { Age=1,Name="张三"},
                new Student() { Age=2,Name="李四"}
            };
            list = list.Where(ss.And(ss1).Compile()).ToList();
            //var a = list.Where(ss);
            Console.WriteLine("sdsds");
            Console.ReadKey();
        }
    }
    public static class DynamicLinqExpressions
    {

        public static Expression<Func<T, bool>> True<T>() { return f => true; }
        public static Expression<Func<T, bool>> False<T>() { return f => false; }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1,
                                                            Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.Or(expr1.Body, invokedExpr), expr1.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
                                                             Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.And(expr1.Body, invokedExpr), expr1.Parameters);
        }

    }
}
