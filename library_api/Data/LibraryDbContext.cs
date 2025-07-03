using library_api.Models;
using Microsoft.EntityFrameworkCore;

namespace library_api.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options){ }
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Automatically adds WHERE Clause for soft delete
        modelBuilder.Entity<Book>().HasQueryFilter(b => !b.IsDeleted);
        modelBuilder.Entity<Author>().HasQueryFilter(a => !a.IsDeleted);
        modelBuilder.Entity<Publisher>().HasQueryFilter(p => !p.IsDeleted);
    }
}