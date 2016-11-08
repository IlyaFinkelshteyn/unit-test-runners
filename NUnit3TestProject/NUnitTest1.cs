using NUnit.Framework;
using System.Diagnostics;

namespace NUnit3TestProject
{
    [SetUpFixture]
    public class MySetUpClass
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Trace.WriteLine("One Time SetUp");
        }

    [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            Trace.WriteLine("One Time TearDown");
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
