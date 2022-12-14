using Xunit;

namespace Store.Tests
{
    public class BookTest
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("   ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 132");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 012-3");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx ISBN 123-456-789 1234 yyy");

            Assert.False(actual);
        }
    }
}