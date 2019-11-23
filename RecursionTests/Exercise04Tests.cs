using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise04Tests
    {
        [Test]
        public void TestZeroValues()
        {
            var actualResult = Exercise04.Run(0, 0);
            actualResult.Should().Be(1);
        }

        [Test]
        public void TestEqualValues()
        {
            var expectedValues = new[] {3, 7, 61, 5, 13, 65533};
            for (var i = 1; i < 4; i++)
            {
                var actualResult = Exercise04.Run(i, i);
                actualResult.Should().Be(expectedValues[i]);
            }
        }

        [Test]
        public void TestZeroN()
        {
            var expectedValues = new[] {1, 2, 3, 5, 13};
            for (var i = 0; i < 5; i++)
            {
                var actualResult = Exercise04.Run(i, 0);
                actualResult.Should().Be(expectedValues[i]);
            }
        }

        [Test]
        public void TestMatrix()
        {
            var expectedValues = new[,]
            {
                {1, 2, 3, 4, 5, 6},
                {2, 3, 4, 5, 6, 7},
                {3, 5, 7, 9, 11, 13},
                {5, 13, 29, 61, 125, 253}
            };

            for (var i = 0; i < expectedValues.GetLength(0); i++)
            for (var j = 0; j < expectedValues.GetLength(1); j++)
            {
                var actualResult = Exercise04.Run(i, j);
                actualResult.Should().Be(expectedValues[i, j]);
            }
        }

        [Test]
        public void TestConstantM()
        {
            var expectedValues = new[] {1, 2, 3, 4, 13};
            for (var i = 0; i < 20; i++)
            {
                var actualResult = Exercise04.Run(0, i);
                actualResult.Should().Be(expectedValues[i]);
            }
        }
    }
}
