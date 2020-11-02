using APIDesign.Classes;
using APIDesign.Proxies;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace APIDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new HelloWorldProxy().GetMessage());
            PersonObject myPer = new PersonObject();
             new PersonObject().CreateObjects();
            new PersonObject().CreateStructs();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    
}
