using System;
using System.Collections.Generic;

namespace DataContext.Entities
{
    public class Author : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Born { get; set; }
        public string City { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
