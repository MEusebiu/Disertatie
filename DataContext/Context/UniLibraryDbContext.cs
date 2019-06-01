using DataContext.Entities;
using System.Data.Entity;

namespace DataContext.Context
{
    public class UniLibraryDbContext : DbContext
    {
        public UniLibraryDbContext() : base("name=UniversityDb")
        {   }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<GenreBookLink> GenreBookLink { get; set; }
        public DbSet<AuthorBookLink> AuthorBookLink { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
