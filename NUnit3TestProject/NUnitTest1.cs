using NUnit.Framework;
using System;
    
namespace NUnit3TestProject2
{
    [SetUpFixture]
    public class MySetUpClass
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Console.WriteLine("One Time SetUp");
        }

    [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            Console.WriteLine("One Time TearDown");
        }
    }
    
    [TestFixture]
    public class NUnit3Tests
    {
        [Test]
        public void Nunit3TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Nunit3TestMethod2()
        {
            Assert.AreNotEqual(1, 2);
        }       
    }
}
