using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise12Tests
    {
        [Test]
        public void TestSimpleFilter()
        {
            var actualResult = Exercise12.Flatten(new Filter());

            actualResult.Should().NotBeNull();
            actualResult.Count.Should().Be(1);
            actualResult.First().Should().NotBeNull();
            actualResult.First().Length.Should().Be(1);
        }

        [Test]
        public void TestSingleCompositeAnyFilter()
        {
            var filters = new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter());
            var actualResult = Exercise12.Flatten(filters);

            actualResult.Should().NotBeNull();
            actualResult.Count.Should().Be(3);
            foreach (var filterSet in actualResult)
            {
                filterSet.Should().NotBeNull();
                filterSet.Length.Should().Be(1);
            }
        }

        [Test]
        public void TestSingleCompositeAllFilter()
        {
            var filters = new CompositeFilter(CompositeFilterOperation.All, new Filter(), new Filter(), new Filter());
            var actualResult = Exercise12.Flatten(filters);

            actualResult.Should().NotBeNull();
            actualResult.Count.Should().Be(1);
            actualResult.First().Should().NotBeNull();
            actualResult.First().Length.Should().Be(3);
        }

        [Test]
        public void TestNestedCompositeAllFilter()
        {
            var filters = new CompositeFilter(CompositeFilterOperation.All,
                new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
                new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
                new CompositeFilter(CompositeFilterOperation.All, new Filter(), new Filter()),
                new Filter());
            var actualResult = Exercise12.Flatten(filters);

            actualResult.Should().NotBeNull();
            actualResult.Count.Should().Be(9);
            foreach (var filterSet in actualResult)
            {
                filterSet.Should().NotBeNull();
                filterSet.Length.Should().Be(5);
            }
        }

        [Test]
        public void TestNestedCompositeAnyFilter()
        {
            var filters = new CompositeFilter(CompositeFilterOperation.All,
                new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
                new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
                new CompositeFilter(CompositeFilterOperation.All, new Filter(), new Filter()),
                new Filter());
            var actualResult = Exercise12.Flatten(filters);

            actualResult.Should().NotBeNull();
            actualResult.Count.Should().Be(8);
        }
    }
}
