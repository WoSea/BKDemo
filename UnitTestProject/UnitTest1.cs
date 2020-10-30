using System;
using System.CodeDom;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WriteSeparatorLine();
            Debug.WriteLine("Required: TestMethod");
            Debug.WriteLine("A test method to be run by the test runner.");
            Debug.WriteLine("This method will appear in the test list.");
            Assert.IsTrue(true);
        }

       
        private static void WriteSeparatorLine()
        {
            Debug.WriteLine("===========================================");
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            WriteSeparatorLine();
            Debug.WriteLine("Optional: AssemblyInitialize");
            Debug.WriteLine("Execute once before the test run.");
        }

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            WriteSeparatorLine();
            Debug.WriteLine("Optional: ClassInitialize");
            Debug.WriteLine("Execute once before the test class.");
        }

        [TestInitialize]
        public void Setup()
        {
            WriteSeparatorLine();
            Debug.WriteLine("Optional: TestInitialize");
            Debug.WriteLine("Execute once before each test.");
        } 

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            WriteSeparatorLine();
            Debug.WriteLine("Optional: AssemblyCleanup");
            Debug.WriteLine("Executes once after the test run.");
        }
        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            WriteSeparatorLine();
            Debug.WriteLine("Optional: ClassCleanup"); 
            Debug.WriteLine("Runs once after all tests in the class have been executed.");
            Debug.WriteLine("Not guaranteed that it executes instantly after all tests the class have executed.");
        }

        public void TearDown()
        {
            WriteSeparatorLine();
            Debug.WriteLine("Optional: TestCleanup");
            Debug.WriteLine("Runs after each test.");
            Assert.Fail();
        }
     }
}
