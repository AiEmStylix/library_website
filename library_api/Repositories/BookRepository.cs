using library_api.Data;
using library_api.Interfaces;
using library_api.Models;

namespace library_api.Repositories;

public class BookRepository(LibraryDbContext context) : Repository<Book>(context), IBookRepository
{
    // The primary constructor 'BookRepository(DataContext context)' automatically
    // captures the 'context' and passes it to the base 'Repository<Book>' constructor.
    // The class body can be used to implement any custom methods defined in IBookRepository.
}