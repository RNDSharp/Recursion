using System;
using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise05Tests
    {
        [Test]
        public void TestNegativeNumber()
        {
            var actualResult = Exercise05.Run(-2);
            actualResult.Should().BeFalse();
        }

        [Test]
        public void TestZeroNumber()
        {
            var actualResult = Exercise05.Run(0);
            actualResult.Should().BeFalse();
        }

        [Test]
        public void TestCorrectPowers()
        {
            for (var i = 1; i < 30; i++)
            {
                var actualResult = Exercise05.Run((int) Math.Pow(2, i));
                actualResult.Should().BeTrue();
            }
        }

        [Test]
        public void TestIncorrectPowers()
        {
            for (var i = 1; i < 30; i++)
            {
                var actualResult = Exercise05.Run((int) Math.Pow(2, i) + 1);
                actualResult.Should().BeFalse();
            }
        }
    }
}
