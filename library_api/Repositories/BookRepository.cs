using library_api.Data;
using library_api.Interfaces;
using library_api.Models;
using Microsoft.EntityFrameworkCore;

namespace library_api.Repositories;

public class BookRepository(LibraryDbContext context) : Repository<Book>(context), IBookRepository
{
    // The primary constructor 'BookRepository(DataContext context)' automatically
    // captures the 'context' and passes it to the base 'Repository<Book>' constructor.
    // The class body can be used to implement any custom methods defined in IBookRepository.
    public override async Task<Book?> GetByIdAsync(int id)
    {
        return await context.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public override async Task<IEnumerable<Book>> GetAllAsync()
    {
        return await context.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .ToListAsync();
    }
}