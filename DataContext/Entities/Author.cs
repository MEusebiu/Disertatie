using System.Collections.Generic;

namespace DataContext.Entities
{
    public class Author : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
