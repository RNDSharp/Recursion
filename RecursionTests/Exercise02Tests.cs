using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise02Tests
    {
        [TestCase(10, 10, "10", Description = "Same numbers")]
        [TestCase(15, 20, "15 16 17 18 19 20", Description = "Positive numbers")]
        [TestCase(20, 15, "20 19 18 17 16 15", Description = "Positive numbers descending")]
        [TestCase(-3, -1, "-3 -2 -1", Description = "Negative numbers")]
        [TestCase(3, -1, "3 2 1 0 -1", Description = "Positive and negative numbers")]
        public void Test_Exercise2(int a, int b, string expected)
        {
            var actualResult = Exercise02.Run(10, 10);
            actualResult.Should().BeEquivalentTo(expected);
        }
    }
}
