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
            // Method A is fixed
            Console.WriteLine($"{nameof(MethodA)} is called");
        }

        public void MethodB()
        {
            // this is a bugfix
            Console.WriteLine($"{nameof(MethodB)} is called");
        }
    }
}
