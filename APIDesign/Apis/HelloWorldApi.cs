using APIDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIDesign.Apis
{
    internal class HelloWorldApi : HelloWorldInterface
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}
