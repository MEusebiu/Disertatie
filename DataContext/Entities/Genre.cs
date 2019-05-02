using System.Collections.Generic;

namespace DataContext.Entities
{
    public class Genre : Entity
    {
        public string Name { get; set; }

        public ICollection<Author> Authors { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
