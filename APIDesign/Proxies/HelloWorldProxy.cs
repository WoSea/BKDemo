using APIDesign.Apis;
using APIDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIDesign.Proxies
{
    class HelloWorldProxy:HelloWorldInterface
    {  
        public string GetMessage()
        {
            return new HelloWorldApi().GetMessage();
        }
    }
}
