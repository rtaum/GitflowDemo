﻿using System;
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
            Console.WriteLine($"{nameof(MethodB)} is called");
        }
    }
}
