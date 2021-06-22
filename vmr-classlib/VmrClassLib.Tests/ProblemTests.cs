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
        public void SolutionTest()
        {
            Assert.True(Problem.Solution());
        }
    }
}