using LINQAndTesting.Library;
using System;
using Xunit;

namespace LINQAndTesting.Tests
{
    // typically one test class to test each
    //  real class
    public class MyCollectionTests
    {
        // Attribute - Special kind of class
        //  that adds extra behavior to a class, method,
        //  property, etc
        [Fact]
        public void EmptyCollectionShouldHaveZeroLength()
        {
            // Arrange
            //  Set up the situation to be tested
            // Sometimes acronym "SUT" for "subject under test" is used
            var sut = new MyCollection();

            // Act
            //  Run the method or behavior that we're 
            //  specifically testing
            var result = sut.Length;

            // Assert
            //  Define what the correct result is and 
            //   check that we got it
            Assert.Equal(0, result);
        }

        // [Fact] is for tests that do not take parameters
        // [Theory] is a convenient way to run a parameterized 
        //  test with more tan one set of data
        [Theory]
        [InlineData(new string[] { "a", "ab" }, "ab")]
        [InlineData(new string[] { "ab", "a" }, "ab")]
        [InlineData(new string[] { "a" }, "a")]
        [InlineData(new string[] { "ab", "b2" }, "ab")]
        [InlineData(new string[] { "ab", null, "a" }, "ab")]
        [InlineData(new string[] { "", }, "")]
        [InlineData(new string[] { }, null)]
        public void LogestShouldReturnLongest(string[] items, string expected)
        {
            // Arrange
            var coll = new MyCollection();
            foreach (var item in items)
            {
                coll.Add(item);
            }

            // Act
            string actual = coll.Longest();

            // Assert
            Assert.Equal(expected, actual);

        }

        // Test driven development:
        //  1) Write tests that fail
        //  2) Write the code to make the tests pass

        [Fact]
        public void EmptyShouldBeEmpty()
        {
            var coll = new MyCollection();

            var actual = coll.Empty();
        }

    }
}
