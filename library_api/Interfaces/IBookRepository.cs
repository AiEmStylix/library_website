using library_api.Models;

namespace library_api.Interfaces;

public interface IBookRepository : IRepository<Book>
{
    Task<Book?> GetByIdUnfilteredAsync(int id);
}