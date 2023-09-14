using Microsoft.EntityFrameworkCore;

namespace LibraryProj.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        { }

		public DbSet<User> Users { get; set; } = null!;
		public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Administrator",
                    Username = "admin",
                    Password = "admin",
                }
                );
       

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Assad" },
                new Author { AuthorId = 2, Name = "Adham" },
                new Author { AuthorId = 3, Name = "Orwa" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Name = "Test 1",
                    Eddition = "First",
                    AuthorId = 1,

                },
                new Book
                {
                    BookId = 2,
                    Name = "Test 2",
                    Eddition = "Second",
                    AuthorId = 2,
                },
                new Book
                {
                    BookId = 3,
                    Name = "Test 3",
                    Eddition = "Third",
                    AuthorId = 3,
                }
                );

        }
    }
}
