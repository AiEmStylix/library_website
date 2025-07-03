using library_api.DTOs;

namespace library_api.Interfaces;

public interface IBookService
{
    Task<BookDto?> GetBookByIdAsync(int id);
    Task<IEnumerable<BookDto>> GetAllBooksAsync();
    Task<BookDto> CreateBookAsync(CreateBookDto createBookDto);
    Task<bool> UpdateBookAsync(int id, UpdateBookDto updateBookDto);
    Task<bool> DeleteBookAsync(int id);
}