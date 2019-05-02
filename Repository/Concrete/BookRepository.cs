using Repository.Abstract;
using System;
using System.Collections.Generic;
using DataContext.Entities;

namespace Repository.Concrete
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book FindBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        
    }
}
