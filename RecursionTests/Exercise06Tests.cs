using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise06Tests
    {
        [TestCase(0, 0, Description = "Zero")]
        [TestCase(1354626729, 45, Description = "Positive number")]
        [TestCase(-1354626729, 45, Description = "Negative number")]
        [TestCase(2000000000, 2, Description = "Rounded number")]
        [TestCase(999999999999, 108, Description = "Very big number")]
        public void Test_Exercise6(long n, long expected)
        {
            var actualResult = Exercise06.Run(n);
            actualResult.Should().Be(expected);
        }
    }
}
