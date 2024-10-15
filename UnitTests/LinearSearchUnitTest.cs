
using SearchingAlgorithms;

namespace UnitTests
{
    public class LinearSearchUnitTest
    {
        [Fact]
        public void TestMiddleItemFound()
        {
            var testItems = new[] { "Florida", "Georgia", "Delaware", "Alabama", "California" };
            var expected = 2;
            var actual = Search.LinearSearch(testItems, "Delaware");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFirstItemFound()
        {
            var testItems = new[] { "Florida", "Georgia", "Delaware", "Alabama", "California" };
            var expected = 0;
            var actual = Search.LinearSearch(testItems, "Florida");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLastItemFound()
        {
            var testItems = new[] { "Florida", "Georgia", "Delaware", "Alabama", "California" };
            var actual = Search.LinearSearch(testItems, "California");
            Assert.Equal(4, actual);
        }

        [Fact]
        public void TestItemNotFound()
        {
            var testItems = new[] { "Florida", "Georgia", "Delaware", "Alabama", "California" };
            var actual = Search.LinearSearch(testItems, "London");
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void TestEmptyList()
        {
            var testItems = new string[] { };
            var actual = Search.LinearSearch(testItems, "London");
            Assert.Equal(-1, actual);
        }

        [Fact(Skip = "Ignore")]
        public void TestNull()
        {
            string[] testItems = null;
            var expected = -1;
            var actual = Search.LinearSearch(testItems, "London");
            Assert.Equal(expected, actual);
        }
    }
}