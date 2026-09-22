using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day55
{
     class CustomExceptionExp
    {
    }

    class SenakFileNotFoundExcpetion : Exception {
         public SenakFileNotFoundExcpetion(string message) : base(message) { }
    }

}
