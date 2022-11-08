using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 12312-31232", "M. Fowler",  "Refactoring"),
            new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetByIsbn(string isbn)
        {
            return books.Where(book => book.ISBN == isbn)
                        .ToArray();
        }

        public Book[] GetByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query)
                                    || book.Author.Contains(query))
                        .ToArray();
        }
    }
}