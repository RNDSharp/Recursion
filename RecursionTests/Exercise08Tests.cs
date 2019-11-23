using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise08Tests
    {
        [TestCase(0, "0", Description = "Zero")]
        [TestCase(1354626729, "1 3 5 4 6 2 6 7 2 9", Description = "Positive number")]
        [TestCase(-1354626729, "1 3 5 4 6 2 6 7 2 9", Description = "Negative number")]
        [TestCase(2000000000, "2 0 0 0 0 0 0 0 0 0", Description = "Rounded number")]
        [TestCase(999999999999, "9 9 9 9 9 9 9 9 9 9 9 9", Description = "Big number")]
        public void Test_Exercise8(long n, string expected)
        {
            var actualResult = Exercise08.Run(n);
            actualResult.Should().BeEquivalentTo(expected);
        }
    }
}
