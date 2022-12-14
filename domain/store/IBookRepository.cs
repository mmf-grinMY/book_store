using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IBookRepository
    {
        Book[] GetByIsbn(string isbn);

        Book[] GetByTitleOrAuthor(string titleOrAuthor);

        Book GetById(int id);
    }
}
