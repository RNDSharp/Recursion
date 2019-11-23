using FluentAssertions;
using NUnit.Framework;
using RecursionTasks;

namespace RecursionTests
{
    [TestFixture]
    public class Exercise09Tests
    {
        [TestCase("", true, Description = "Empty string")]
        [TestCase("GoodDayyaDdooG", true, Description = "Even length palindrome")]
        [TestCase("GoodDayaDdooG", true, Description = "Odd length palindrome")]
        [TestCase("NiceDayyaDdooG", false, Description = "Even length string")]
        [TestCase("BadDayyaDdooG", false, Description = "Odd length string")]
        [TestCase("y", true, Description = "Single letter")]
        [TestCase("GOODDAYyaddoog", true, Description = "Capitalized palindrome")]
        public void Test_Palindrome(string s, bool expected)
        {
            var actualResult = Exercise09.Run(s);
            actualResult.Should().Be(expected);
        }
    }
}
