using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise10Tests
    {
        [TestCase(0, 0, 1)]
        [TestCase(0, 8, 1)]
        [TestCase(8, 0, 1)]
        [TestCase(5, 8, 126)]
        public void Test_Exercise10(int a, int b, int expected)
        {
            var actualResult = Exercise10.Run(a, b);
            actualResult.Should().Be(expected);
        }
    }
}
