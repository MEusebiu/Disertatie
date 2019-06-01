using System.Collections.Generic;

namespace DataContext.Entities
{
    public class Genre : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
