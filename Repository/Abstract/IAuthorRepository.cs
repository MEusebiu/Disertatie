using DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllAuthors();
        void AddAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(Author author);
        Author GetAuthorById(int authorId);
        void Save();
    }
}
