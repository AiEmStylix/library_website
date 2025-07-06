using library_api.Data;
using library_api.Interfaces;
using library_api.Models;
using Microsoft.EntityFrameworkCore;

namespace library_api.Repositories;

public class BookRepository(LibraryDbContext context) : Repository<Book>(context), IBookRepository
{
    public override async Task<Book?> GetByIdAsync(int id)
    {
        return await Context.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public override async Task<IEnumerable<Book>> GetAllAsync()
    {
        return await Context.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .ToListAsync();
    }

    public async Task<Book?> GetByIdUnfilteredAsync(int id)
    {
        return await Context.Books
            .IgnoreQueryFilters() // This MUST be here, before the Includes
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .FirstOrDefaultAsync(b => b.Id == id);
    }
}