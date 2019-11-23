using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise01Tests
    {
        [TestCase(1, "1", Description = "Simplest case")]
        [TestCase(11, "1 2 3 4 5 6 7 8 9 10 11", Description = "From 1 to 11")]
        [TestCase(0, "", Description = "Invalid input")]
        [TestCase(-5, "", Description = "Invalid input")]
        public void Test_Exercise1(int input, string expected)
        {
            var actualResult = Exercise01.Run(input);
            actualResult.Should().BeEquivalentTo(expected);
        }
    }
}
