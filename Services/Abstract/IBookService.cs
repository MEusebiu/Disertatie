using DataContext.Entities;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        void UpdateBook(Book book);
        Book FindBookById(int bookId);
        void DeleteBook(Book book);
    }
}
