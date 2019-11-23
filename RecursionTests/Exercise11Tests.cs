using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise11Tests
    {
        [TestCase(1584, 4851)]
        [TestCase(158, 851)]
        [TestCase(0, 0)]
        [TestCase(115511, 115511)]
        [TestCase(2147483647, 7463847412)]
        [TestCase(-12, -11)]
        public void Test_ReverseNumber(long n, long expected)
        {
            var actualResult = Exercise11.Run(n);
            actualResult.Should().Be(expected);
        }
    }
}
