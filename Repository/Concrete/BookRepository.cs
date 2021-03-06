﻿using Repository.Abstract;
using System;
using System.Collections.Generic;
using DataContext.Entities;
using DataContext.Context;
using System.Linq;
using System.Data.Entity;

namespace Repository.Concrete
{
    public class BookRepository : IBookRepository
    {
        private UniLibraryDbContext db;

        public BookRepository(UniLibraryDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        public void AddBook(Book book)
        {
            db.Books.Add(book);
            Save();
        }

        public void DeleteBook(Book book)
        {
            db.Books.Remove(book);
            Save();
        }

        public Book FindBookById(int bookId)
        {
            return db.Books.Where(x => x.Id == bookId).FirstOrDefault();
        }

        public void UpdateBook(Book book)
        {
            //db.Entry(book).State = EntityState.Modified;
            //Save();
            db.Set<Book>().Attach(book);
            db.Entry(book).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
