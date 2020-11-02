using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace APIDesign.Classes
{
    class PersonObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void CreateObjects()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var people = new List<PersonObject>();
            for (var i = 1; i <= 1000000; i++)
            {
                people.Add(new PersonObject
                {
                    FirstName = "Person",
                    LastName =
                $"Number {i}"
                });
            }
            stopwatch.Stop();
            Console.WriteLine($"Object: {stopwatch.ElapsedMilliseconds}, Object Count: { people.Count}");
            GC.Collect();
        }
        public  void CreateStructs()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var people = new List<PersonStruct>();
            for (var i = 1; i <= 1000000; i++)
            {
                people.Add(new PersonStruct("Person", $"Number {i}"));
            }
            stopwatch.Stop();
            Console.WriteLine($"Struct: {stopwatch.ElapsedMilliseconds}, Struct   Count: { people.Count}  ");
            GC.Collect();
        }
    }
    public struct PersonStruct
    {
        private readonly string _firstName;
        private readonly string _lastName;
        public PersonStruct(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string FirstName => _firstName;
        public string LastName => _lastName;
    }
   
}
