using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise03Tests
    {
        [TestCase(10, 10, "10", Description = "Same numbers")]
        [TestCase(15, 20, "15 16 17 18 19 20", Description = "Two positive numbers")]
        [TestCase(20, 15, "15 16 17 18 19 20", Description = "Two positive numbers descending")]
        [TestCase(-3, -1, "-3 -2 -1", Description = "Negative numbers ascending")]
        [TestCase(-1, 3, "-1 0 1 2 3", Description = "Mixed numbers ascending")]
        public void Test_Exercise3(int a, int b, string expected)
        {
            var actualResult = Exercise03.Run(a, b);
            actualResult.Should().BeEquivalentTo(expected);
        }
    }
}
