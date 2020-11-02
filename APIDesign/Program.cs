using APIDesign.Proxies;
using System;

namespace APIDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new HelloWorldProxy().GetMessage());
            Console.ReadKey();
        }
    }
}
