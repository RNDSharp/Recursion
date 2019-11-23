using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise07Tests
    {
        [TestCase(0, "0", Description = "Zero")]
        [TestCase(1354626729, "9 2 7 6 2 6 4 5 3 1", Description = "Positive number")]
        [TestCase(-1354626729, "9 2 7 6 2 6 4 5 3 1", Description = "Negative number")]
        [TestCase(2000000000, "0 0 0 0 0 0 0 0 0 2", Description = "Rounded number")]
        [TestCase(999999999999, "9 9 9 9 9 9 9 9 9 9 9 9", Description = "Very big number")]
        public void Test_Exercise7(long n, string expected)
        {
            var actualResult = Exercise07.Run(n);
            actualResult.Should().BeEquivalentTo(expected);
        }
    }
}
