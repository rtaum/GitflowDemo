using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class BusinessLogic
    {
        public void MethodA()
        {
            Console.WriteLine($"{nameof(MethodA)} is called");
        }

        public void MethodB()
        {
            // this is a bugfix
            Console.WriteLine($"{nameof(MethodB)} is called");
        }

        public void MethodC()
        {
            // new, very importan comment
            Console.WriteLine($"{nameof(MethodC)} is called");
        }

        public void MethodD()
        {
            Console.WriteLine($"{nameof(MethodD)} is called");
        }
    }
}
