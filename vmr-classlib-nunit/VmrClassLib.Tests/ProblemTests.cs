using NUnit.Framework;

namespace VmrClassLib.Tests
{
    public class ProblemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.True(Problem.Solution());
        }
    }
}